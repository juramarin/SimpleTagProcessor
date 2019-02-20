using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleTagProcessor.Common
{
    public static class BitStringValidator
    {
        public static bool IsValidSGTIN96BitString(string bitString)
        {
            Match result = Regex.Match(bitString, @"^([0-1]){96}$");
            if (result.Success)
            {
                return true;
            }
            return false;
        }
    }
}
