using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SMA.CSV.Merger
{
    public class SmaCsv
    {
        
        public static List<string> GetColumns(string filecontent)
        {
            var x = filecontent.IndexOf("\"Time period");  //header start
            var y = filecontent.IndexOf("\n", x + 1);      //header end                                 
            var s = filecontent.Substring(x, y - x);      //header line
            var arr = s.Split(new char[] { ';' });        //columns

            var r = new List<string>();
            foreach(string item in arr)
            {
                var colName = item.Substring(1, item.Length - 2); //remove " encapsulation
                r.Add(colName);
            }

            return r;

        }

        public static string RemoveOverhead(string filecontent)
        {
            var i = filecontent.IndexOf("\"Time period");

            if (i != -1)
                return filecontent.Substring(i);
            else
                return filecontent;
        }

        public static string GenOutputFileName(string template)
        {
            //e.g. input file like "Consumer balance -Month - 1012_UserName - 2024 - 09.csv"
            //returns              "Consumer balance - Month.csv;

            var templateFileName = Path.GetFileName(template);
            var path = Path.GetDirectoryName(template);
            var file = new string(template.TakeWhile(c => !char.IsDigit(c)).ToArray()).Trim();

            if (file.Last() == '-')
                file = file.Substring(0, file.Length - 1);


            return file.Trim();
        }
    }
}
