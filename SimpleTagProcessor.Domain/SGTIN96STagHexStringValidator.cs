using System;

namespace SimpleTagProcessor.Domain
{
    public class SGTIN96STagHexStringValidator : ITagHexStringValidator
    {
        private const int SGTIN96_STRING_LENGTH = 24;
        private const string SGTIN96_HEADER_VALUE = "30";

        public bool IsValidTagHexString(string tagString)
        {
            if (string.IsNullOrWhiteSpace(tagString)) throw new ArgumentException("Tag String must NOT be null or empty", "tagString");
            var a = IsRequiredLength(tagString);
            var b = IsHeaderCorrect(tagString);
            var c = IsStringHexNumber(tagString);

            return a && b && c;
        }

        private bool IsRequiredLength(string tagString)
        {
            return tagString.Length == SGTIN96_STRING_LENGTH ? true : false;
        }

        private bool IsHeaderCorrect(string tagString)
        {
            if (tagString.Length > 1)
            {
                return tagString.Substring(0, 2) == SGTIN96_HEADER_VALUE ? true : false;
            }
            return false;
        }

        private bool IsStringHexNumber(string tag)
        {
            bool isHex;
            foreach (var c in tag)
            {
                isHex = ((c >= '0' && c <= '9') ||
                         (c >= 'a' && c <= 'f') ||
                         (c >= 'A' && c <= 'F'));

                if (!isHex)
                    return false;
            }
            return true;
        }
    }
}