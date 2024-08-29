﻿using System;
using System.Globalization;
using System.Windows;

namespace ApeRadar.Models
{
    public enum Language
    {
        AUTO,
        EN_US,
        ZH_CN,
    }
    public static class LanguageExt
    {
        public static Language GetLanguageByName(string name)
        {
            return name switch
            {
                "AUTO" => Language.AUTO,
                "EN_US" => Language.EN_US,
                "ZH_CN" => Language.ZH_CN,
                _ => throw new ArgumentException(),
            };
        }
        public static string GetNameByLanguage(Language language)
        {
            return language switch
            {
                Language.AUTO => "AUTO",
                Language.EN_US => "EN_US",
                Language.ZH_CN => "ZH_CN",
                _ => throw new ArgumentException(),
            };
        }
        public static ResourceDictionary GetResourceDictionaryByLanguage(Language language)
        {
            return language switch
            {
                Language.AUTO => CultureInfo.CurrentUICulture.TwoLetterISOLanguageName switch
                {
                    "zh" => new ResourceDictionary { Source = new Uri("/Resources/Localization/zh-cn.xaml", UriKind.RelativeOrAbsolute) },
                    _ => new ResourceDictionary { Source = new Uri("/Resources/Localization/en-us.xaml", UriKind.RelativeOrAbsolute) },
                },
                Language.EN_US => new ResourceDictionary { Source = new Uri("/Resources/Localization/en-us.xaml", UriKind.RelativeOrAbsolute) },
                Language.ZH_CN => new ResourceDictionary { Source = new Uri("/Resources/Localization/zh-cn.xaml", UriKind.RelativeOrAbsolute) },
                _ => CultureInfo.CurrentUICulture.TwoLetterISOLanguageName switch
                {
                    "zh" => new ResourceDictionary { Source = new Uri("/Resources/Localization/zh-cn.xaml", UriKind.RelativeOrAbsolute) },
                    _ => new ResourceDictionary { Source = new Uri("/Resources/Localization/en-us.xaml", UriKind.RelativeOrAbsolute) },
                },
            };
        }
    }
}
