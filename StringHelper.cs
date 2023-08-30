using System;
using System.Collections.Generic;
using System.Text;

namespace UtilGenerator
{
    internal static class StringHelper
    {
        internal static string Between(string input, string firstString, string lastString)
        {
            string FinalString;
            int Pos1 = input.IndexOf(firstString) + firstString.Length;
            int Pos2 = input.LastIndexOf(lastString);
            FinalString = input.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }
    }
}
