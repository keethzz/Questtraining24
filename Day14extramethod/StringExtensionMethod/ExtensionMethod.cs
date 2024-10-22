using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14extramethod.StringExtensionMethod
{
    internal static class ExtensionMethod
    {
        public static string ToTitleCase(this string str)
        {
            if (str == null)
            {
                return null;
            }

            var words = str.Split(' '); // Split the string by spaces
            var sb = new StringBuilder();

            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    sb.Append(char.ToUpper(word[0]) + word.Substring(1).ToLower() + " ");
                }
            }

            return sb.ToString().Trim(); // Remove the trailing space at the end
        }

    }
}
