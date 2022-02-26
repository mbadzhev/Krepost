namespace KrepostLib
{
    public static class Utility
    {
        public static bool CompareStrings(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;
            if (str1.Length < 1 || str2.Length < 1)
                return false;
            if (str1 != str2)
                return false;
            return true;
        }
    }
}
