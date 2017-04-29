using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class  ExtendedConverters
    {
        public static DateTime ToDateTime(this string date)
        {
            return Convert.ToDateTime(date);
        }
    }
}
