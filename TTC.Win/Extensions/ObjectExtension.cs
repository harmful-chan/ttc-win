using System;
using System.Collections.Generic;
using System.Text;
using TTC.Win.Models;

namespace TTC.Win.Extensions
{
    internal static class ObjectExtension
    {

        internal static bool Legal(this object o)
        {
            return o != null && o.GetType() != typeof(string);
        }
    }
}
