using SimpleTagProcessor.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTagProcessor.Domain.ConstructorStrategies
{
    public static class SGTIN96FilterConstructor
    {
        private const int FILTER_START_POSITION = 8;
        private const int FILTER_LENGTH = 3;

        public static void ConstructFilter(Tag tag)
        {
            try
            {
                if (tag.Status != TagStatus.HeaderValueOK) throw new InvalidOperationException("ConstructFilter, wrong tag processing sequence");
                if (!BitStringValidator.IsValidSGTIN96BitString(tag.BitStringValue)) throw new ArgumentException("ConstructFilter, Invalid bitString");

                tag.Filter = Convert.ToInt32(tag.BitStringValue.Substring(FILTER_START_POSITION, FILTER_LENGTH), 2);
                tag.Status = TagStatus.FilterValueOK;
            }
            catch (Exception)
            {
                tag.Status = TagStatus.FilterValueError;
                throw;
            }
        }
    }
}
