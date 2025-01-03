using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

using AT.Data;
using AT.ClassExtensions;

using NLog;

namespace SMA.CSV.Merger
{
    public class SmaCsvTableConverter
    {
        static ILogger logger = LogManager.GetCurrentClassLogger();

        List<string> _Files;
        DataTable    _Table;

        public SmaCsvTableConverter(List<string> csvFiles)
        {
            _Files = csvFiles.Distinct().ToList();
        }
        public SmaCsvTableConverter(string[] csvFiles)
        {
            this._Files = csvFiles.Distinct().ToList();
        }

        /// <summary>
        /// //load CSV files into DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable ToDataTable()
        {
            _Table = new DataTable();

            try
            {
                //load csv to dataTable
                foreach (var file in _Files)
                {
                    //load csv
                    var text = File.ReadAllText(file);
                    var csv = SmaCsv.RemoveOverhead(text);

                    //fill column of result table
                    var lstColTypeInfo = this.UpdateColumns(csv);

                    //Copy new data to result table
                    var table = CsvReader.ParseText(csv, true); //returns dataTable
                    this.FillRows(table, lstColTypeInfo);
                }


                //Sort table
                var tableView = _Table.ApplySort((r1, r2) =>
                {
                    var d1 = DateTime.Parse(r1[0].ToString());
                    var d2 = DateTime.Parse(r2[0].ToString());

                    return d1.CompareTo(d2);
                });

                _Table = tableView.Table;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

            return _Table;
        }

        private List<SmaValueInfo> UpdateColumns(string csvInput)
        {
            var lstColNames = SmaCsv.GetColumns(csvInput);
            var lstColTypeInfo = SmaValueInfo.Create(lstColNames);

            for (int i = 0; i < lstColTypeInfo.Count; i++)
            {
                var newColName = lstColTypeInfo[i].NameWithNormalizedUnit; //normalized is W instead of kW

                if (!_Table.Columns.Contains(newColName))
                {
                    if (lstColTypeInfo[i].IsDateTime)
                        _Table.Columns.Add(newColName);
                    else
                        _Table.Columns.Add(newColName, typeof(double));
                }

               //store column index from source and destination table for later access
                lstColTypeInfo[i].CustomTag1 = _Table.Columns.IndexOf(newColName);
                lstColTypeInfo[i].CustomTag2 = i;
            }

            return lstColTypeInfo;

        }

        private void FillRows(DataTable tabInput, List<SmaValueInfo> lstColTypeInfo)
        {
            var formater = new SmaFormater();
            for (int i = 0; i < tabInput.Rows.Count; i++)
            {
                var newCells = new List<string>(_Table.Columns.Count);
                newCells.AddRange("0.0", _Table.Columns.Count);

                foreach (var cty in lstColTypeInfo)
                {
                    var x = cty.CustomTag1; //col index result table
                    var y = cty.CustomTag2; //col index source table

                    var s1 = tabInput.Rows[i][y].ToString();     //format value 
                    var s2 = formater.ValueToString(s1, cty); //e.g. no thousand separator, 24h time format, W instead kW,...

                    newCells[x] = s2;
                }

                _Table.Rows.Add(newCells.ToArray());
            }
        }

    }
}
