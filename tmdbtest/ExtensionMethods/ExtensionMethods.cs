using System;
using System.Collections.Generic;
using System.Text;

namespace tmdbtest.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static string ReplaceSpacesWithPluses(this string s)
        {
            return s.Replace(" ", "+");
        }
    }
}
