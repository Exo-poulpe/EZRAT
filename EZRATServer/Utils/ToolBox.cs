using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRATServer.Utils
{
    public static class ToolBox
    {

        public static string ReduceByteSize(string value)
        {
            int KB = 1024;
            int MB = KB * KB;
            int GB = MB * KB;
            int TB = GB * KB;

            double tmp = Convert.ToDouble(value);
            double result = 0;
            string ResultChar = string.Empty;
            if (tmp < KB)
            {
                result = tmp;
                ResultChar = "B";
            }
            else if (tmp >= KB && tmp < MB)
            {
                result = tmp / KB;
                ResultChar = "KB";
            }
            else if (tmp >= MB && tmp < GB)
            {
                result = tmp / MB;
                ResultChar = "MB";
            }
            else if (tmp >= GB && tmp < TB)
            {
                result = (int)tmp / GB;
                ResultChar = "GB";
            }
            return $"{result.ToString("0.")} {ResultChar}";
        }

    }
}
