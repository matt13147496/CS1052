﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Media3D;
using System.Windows.Media.Animation;

namespace _3DCubeVideo
{
    class LookBackConverter : IValueConverter 
    {
        #region IValueConverter Members

        public object Convert(
            object value, Type targetType, 
            object parameter, 
            System.Globalization.CultureInfo culture)
        {
            return new Point3D(0,0,0) - (Point3D)value;
        }

        public object ConvertBack(
            object value, Type targetType, 
            object parameter, 
            System.Globalization.CultureInfo culture)
        {
            return null;
        }

        #endregion
    }
}
