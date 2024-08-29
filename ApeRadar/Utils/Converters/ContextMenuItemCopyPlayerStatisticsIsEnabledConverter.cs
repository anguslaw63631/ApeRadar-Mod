﻿using ApeRadar.Models;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace ApeRadar.Utils.Converters
{
    internal class ContextMenuItemCopyPlayerStatisticsIsEnabledConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
            {
                return DependencyProperty.UnsetValue;
            }
            Player p = (value as Player)!;
            if (p.Name[..1] != ":" && p.ID != "-1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
