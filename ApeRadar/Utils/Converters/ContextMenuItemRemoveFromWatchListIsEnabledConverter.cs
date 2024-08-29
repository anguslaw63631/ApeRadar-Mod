﻿using ApeRadar.Models;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace ApeRadar.Utils.Converters
{
    internal class ContextMenuItemRemoveFromWatchListIsEnabledConverter : IValueConverter
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
                return p.WatchStatus switch
                {
                    WatchStatus.NONE => false,
                    WatchStatus.POSITIVE => true,
                    WatchStatus.NEGTIVE => true,
                    WatchStatus.CHEATER => true,
                    _ => true,
                };
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
