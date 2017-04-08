using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Common
{
    public class Common
    {
        public static void SetAppSettings(string appPath)
        {
            Settings.AppInitial = ConfigReader.GetAppInitial;
            Settings.AppPath = appPath;
        }

   


    }
    public class KeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
