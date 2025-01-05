using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.IO;
using System.Globalization;

using AT.Data;
using AT.Office.ExcelXML;
using AT.ClassExtensions;

using NLog;


namespace SMA.CSV.Merger.Week
{
    class Program
    {
        static ILogger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// arg 1 = output filename
        /// arg 2 = input source directory or input files
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                //Parse args
                string outputFile = "";
                if (args.Length ==0)
                    ExitError("output files missing");
                else
                    outputFile = args[0];



                List<string> inputFiles = new List<string>();
                if (args.Length == 1)
                    ExitError("input directory or files missing");              
                else if (args.Length == 2)
                    inputFiles = Directory.EnumerateFiles(args[1], "*.csv").ToList();
                else
                    inputFiles = args.Skip(1).ToList();



                //convert CSV files to one table
                var converter = new SmaCsvTableConverter(inputFiles);
                var dataTable = converter.ToDataTable();

                AT.IO.DiskUtil.TryDelete(outputFile);
                               
                var docArgs      = new DocumentInputData();
                docArgs.Data3    = dataTable;
                docArgs.FileName = outputFile;



                if (Path.GetExtension(outputFile) == ".csv")
                {
                    var srvc = new DataListExporter();
                    srvc.DocumentProperties = docArgs;
                    srvc.ExportToCsv();
                }
                else
                {
                    var doc = ExcelDocument.CreateFromDataTable(dataTable, docArgs);
                    doc.Save(outputFile);
                }

                ExitOk(outputFile);

            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }
        }

        static void ExitError(string msg, string arg = "")
        {
            Console.WriteLine(msg);
            logger.Warn(msg + ": " + arg);
            Environment.Exit(0);
        }

        static void ExitOk(string msg)
        {
            Console.WriteLine(msg);
            Environment.Exit(0);
        }
    }
}
