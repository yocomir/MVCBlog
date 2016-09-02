using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBlog.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLendth = 100)
        {
            if (text.Length == null || text.Length <= maxLendth)
            {
                return text;
            }
            else
            {
                var shortText = text.Substring(0, maxLendth) + "...";
                return shortText;
            }
        }
    }
}