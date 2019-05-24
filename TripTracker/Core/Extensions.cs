using System;
using System.Globalization;

namespace Core
{
    public static class Extensions
    {
        public static bool EqualsIgnoreCase(this string a, string b)
            => a.Equals(b, StringComparison.InvariantCultureIgnoreCase);

        public static DateTime ParseTime(this string text)
            => DateTime.ParseExact(text, "HH:mm", CultureInfo.InvariantCulture);
    }
}
