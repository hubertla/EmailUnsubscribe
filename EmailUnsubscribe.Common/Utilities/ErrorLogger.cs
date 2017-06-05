using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EmailUnsubscribe.Common.Utilities
{
    // Application logger utility
    public class ErrorLogger
    {
        private static readonly string _path = HttpContext.Current.Server.MapPath("~/App_Data/ElmahError");

        /// <summary>
        /// Limit the number of log files (default is 100) as the log is stored in xml file
        /// 
        /// </summary>
        public static void LimitLogFile(int logFileNumber = 100)
        {
            int errorLogSize = logFileNumber;

            var errorCount = Directory.EnumerateFiles(_path, "*.xml").Count();
            if (errorCount >= errorLogSize)
            {
                // Clear log
            }
        }

        public static void ClearLogFile()
        {
            DirectoryInfo di = new DirectoryInfo(_path);
            foreach (var fi in di.GetFiles())
            {
                fi.Delete();
            }
        }

        public static void FilterSpamErrors(ExceptionFilterEventArgs efea)
        {

        }
    }
}
