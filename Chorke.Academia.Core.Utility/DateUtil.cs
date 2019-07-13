using System;
using System.Globalization;

namespace Chorke.Academia.Core.Utility
{
    public class DateUtil
    {
        public const string DD_MM_YYYY = "dd/MM/yyyy";

        public static string Format(DateTime date) => Format(date, DD_MM_YYYY);
        public static string Format(DateTime date, string format) => date.ToString(DD_MM_YYYY);

        public static DateTime Parse(String date) => Parse(date, DD_MM_YYYY);
        public static DateTime Parse(String date, string format) => DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
    }
}