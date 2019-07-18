using System;
using System.Globalization;

namespace Chorke.Academia.Core.Utility
{
    public class DateUtil
    {
        public const string DD_MM_YYYY = "dd/MM/yyyy";
        public const string ISO_DATE = "yyyy-MM-dd'T'HH:mm:ss.fff";
        public const string ISO_8601 = "yyyy-MM-dd'T'HH:mm:ss.fffK";

        public static string Format(DateTime date) => Format(date, DD_MM_YYYY);
        public static string FormatISO(DateTime date) => Format(date, ISO_DATE);
        public static string Format(DateTime date, string format) => date.ToString(format);

        public static DateTime Parse(String date) => Parse(date, DD_MM_YYYY);
        public static DateTime ParseISO(String date) => Parse(date, ISO_DATE);
        public static DateTime Parse(String date, string format) => DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
    }
}