using System;

namespace EZRATClient.Utils
{
    public static class ToolBox
    {

        public static string ReduceByteSize(string value)
        {
            double KB = 1024;
            double MB = KB * KB;
            double GB = MB * KB;
            double TB = GB * KB;
            double PB = TB * KB;
            double ZB = PB * KB;

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
                result = tmp / GB;
                ResultChar = "GB";
            } else if(tmp >= TB && tmp < PB )
            {
                result = tmp / GB;
                ResultChar = "GB";
            }
            return $"{result.ToString("0.")} {ResultChar}";
        }

    }
}
