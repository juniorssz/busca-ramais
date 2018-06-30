using System;
using System.Configuration;

namespace DAL
{
    public static class ReadFile
    {
        public static string getCsvPath()
        {
            return ConfigurationManager.AppSettings["CsvPath"].ToString();
        }        
    }
}
