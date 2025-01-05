using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;


namespace SMA.CSV.Merger
{
    public class SmaValueInfo
    {
        public int CustomTag1;
        public int CustomTag2;

        public string NameSMA;
        public string NameWithoutUnit;
        public string NameWithNormalizedUnit;
        public string Unit;

        public bool IsDateTime;
        public bool IsConsumption;
        public double ConsumpNormFactor;


        public SmaValueInfo(string csvColName)
        {
            this.IsDateTime    = csvColName.Contains("Time period");
            this.IsConsumption = !this.IsDateTime;


            if (csvColName.Contains("[kW")) this.ConsumpNormFactor = 1.0;
            if (csvColName.Contains("[mW")) this.ConsumpNormFactor = 1000.0;
            if (csvColName.Contains("[W"))  this.ConsumpNormFactor = 0.001;


            if (csvColName.Contains("["))
            {
                this.Unit = AT.Text.StringUtil.ExtractText(csvColName, "[", "]");
                this.NameSMA = csvColName;
                this.NameWithoutUnit = AT.Text.StringUtil.ExtractText(csvColName, "", "["); //already trims

                var u1 = String.Format("[{0}]", this.Unit);
                var u2 = u1.Replace("[mW", "[kW").Replace("[W", "[kW");
                this.NameWithNormalizedUnit = this.NameWithoutUnit + " " + u2;
            }
            else
            {
                this.Unit = "";
                this.NameSMA = csvColName;
                this.NameWithoutUnit = csvColName;
                this.NameWithNormalizedUnit = csvColName;
            }
        }


        public static List<SmaValueInfo> Create(List<string> columnNames)
        {
            var lst = new List<SmaValueInfo>(columnNames.Count);
            columnNames.ForEach(x => lst.Add(new SmaValueInfo(x)));

            return lst;
        }
    }
}
