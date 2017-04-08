using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class ConfigReader
    {
        public static string GetAppInitial { get { return System.Configuration.ConfigurationManager.AppSettings["AppInitial"].ToString(); } }
        public static string GetAppMode { get { return System.Configuration.ConfigurationManager.AppSettings["AppMode"].ToString(); } }
    }
}
