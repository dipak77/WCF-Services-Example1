using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DipakWorldService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public int calculateDays(int day, int Month, int year)
        {
            DateTime dt = new DateTime(year, Month, day);
            int datetodays = DateTime.Now.Subtract(dt).Days;
            return datetodays;
        }

        public int calculateAge(int day, int Month, int year)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (year * 100 + Month) * 100 + day;

            return (a - b) / 10000;
        }
    };
}
