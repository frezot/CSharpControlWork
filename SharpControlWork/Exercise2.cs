namespace SharpControlWork
{
    static class Exercise2
    {
        public static double Max(double first, double second)
        {
            return first >= second ? first : second;
        }

        public static string Max(string first, string second)
        {
            return first.Length >= second.Length ? first : second;
        }
    }
}