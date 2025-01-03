using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace SMA.CSV.Merger
{
    public class SmaFormater
    {
        protected CultureInfo _DateTimeProvider;

        public SmaFormater()
        {
            _DateTimeProvider = new CultureInfo("en-US");
            _DateTimeProvider.DateTimeFormat.TimeSeparator = ".";
        }



        public DateTime ValueToTime(string value)
        {
            try
            {
                var d = DateTime.Parse(value, _DateTimeProvider);
                return d;
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        public double ValueToNumber(string value)
        {
            try
            {
                var s = value.Replace(",", "").Replace(".", ",");
                var d = AT.ATConverter.ToDouble(s, 0.0);

                return d;
            }
            catch
            {
                return -1;
            }
        }

        public double ValueToComsumtion(string value, SmaValueInfo formatInfo)
        {
            try
            {
                var s = value.Replace(",", "").Replace(".", ",");
                var d = AT.ATConverter.ToDouble(s, 0.0);
                var r = d * formatInfo.ConsumpNormFactor;

                return r;
            }
            catch
            {
                return -1;
            }
        }

        public string ValueToString(string value, SmaValueInfo formatInfo)
        {
            if (formatInfo.IsDateTime)
            {
                var d = ValueToTime(value);
                return d.ToString("dd.MM.yyyy HH:mm:ss");
            }
            else if (formatInfo.IsConsumption)
            {
                var c = ValueToComsumtion(value, formatInfo);
                return c.ToString();
            }
            else
            {
                var n = this.ValueToNumber(value);
                return n.ToString();
            }
        }
    }
}
