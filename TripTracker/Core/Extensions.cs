namespace Core
{
    public static class Extensions
    {
        public static bool EqualsIgnoreCase(this string a, string b)
            => a.Equals(b, System.StringComparison.InvariantCultureIgnoreCase);
    }
}
