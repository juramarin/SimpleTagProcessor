using SimpleTagProcessor.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTagProcessor.Domain.ConstructorStrategies
{
    public static class SGTIN96HeaderConstructor
    {
        private const int HEADER_START_POSITION = 0;
        private const int HEADER_LENGTH = 8;
        private const int HEADER_VALID_VALUE = 48;

        public static void ConstructHeader(Tag tag)
        {
            try
            {
                if (tag.Status != TagStatus.ConvertedToBitOK) throw new InvalidOperationException("ConstructHeader, wrong tag processing sequence");
                if (! BitStringValidator.IsValidSGTIN96BitString(tag.BitStringValue)) throw new ArgumentException("ConstructHeader, Invalid bitString");

                tag.Header = Convert.ToInt32(tag.BitStringValue.Substring(HEADER_START_POSITION, HEADER_LENGTH), 2);
                tag.Status = TagStatus.HeaderValueOK;
                if (tag.Header != HEADER_VALID_VALUE) throw new ArgumentException("Header value not valid: " + tag.Header.ToString(), "tag.Header");
            }
            catch (Exception)
            {
                tag.Status = TagStatus.HeaderValueError;
                throw;
            }
        }
    }
}
