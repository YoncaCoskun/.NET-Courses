
using System;

namespace Utils
{
    public static class HTMLGenerate
    {
        public static string GenerateUnOrderedList(params string[] items)
        {
            string result = "<ul>";


            foreach (string s in items)
            {
                result += string.Format("<li>{0}</li>", s);
            }

            result += "</ul>";

            return result;
        }
    }
}
