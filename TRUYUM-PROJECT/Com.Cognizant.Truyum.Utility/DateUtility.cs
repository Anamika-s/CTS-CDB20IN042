using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Utility
{
    public static class DateUtility
    {
        public static DateTime ConvertToDate(string inputDate)
        {
            return DateTime.Parse(inputDate);
        }

        
    }
}
