using System;
using System.Collections.Generic;
using System.Text;

namespace TTC.Win.Extensions
{
    internal static class StringExtension
    {
        internal static bool Legal(this string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }
    }
}
