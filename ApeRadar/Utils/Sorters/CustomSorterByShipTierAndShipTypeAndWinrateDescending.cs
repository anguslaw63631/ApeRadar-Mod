﻿using ApeRadar.Models;
using System.Collections;

namespace ApeRadar.Utils.Sorters
{
    internal class CustomSorterByShipTierAndShipTypeAndWinrateDescending : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Player? a = x as Player;
            Player? b = y as Player;
            return a!.ShipTier != b!.ShipTier ? b.ShipTier - a.ShipTier : a.ShipType != b.ShipType ? a.ShipType.CompareTo(b.ShipType) : (Properties.Settings.Default.WinrateTypeUsed == 0) ? (a!.AccountWinrate <= b!.AccountWinrate ? 1 : -1) : (a!.WeightedWinrate <= b!.WeightedWinrate ? 1 : -1);
        }
    }
}
