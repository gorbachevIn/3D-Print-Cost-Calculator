﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PrintCostCalculator3d.Converters
{
    public sealed class DecimalHoursToTimeSpanConverter : IValueConverter
    {
        /* Translate the name of the accent */
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                TimeSpan ts = TimeSpan.FromHours(System.Convert.ToDouble(value));
                // remove ms for displaying
                ts  = ts.Subtract(new TimeSpan(0, 0, 0, 0, ts.Milliseconds));
                return ts;
            }
            catch (Exception)
            {
                return TimeSpan.Zero;
            }


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TimeSpan ts = (TimeSpan)value;
            if (ts == null)
                return 0;
            return ts.TotalHours;
            //throw new NotImplementedException();
        }
    }
}
