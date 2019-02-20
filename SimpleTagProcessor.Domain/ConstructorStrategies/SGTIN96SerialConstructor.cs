using SimpleTagProcessor.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTagProcessor.Domain.ConstructorStrategies
{
    public static class SGTIN96SerialConstructor
    {
        private const int SERIALREFERENCE_START_POSITION = 58;
        private const int SERIALREFERENCE_LENGTH = 38;

        public static void ConstructReference(Tag tag)
        {
            try
            {
                if (tag.Status != TagStatus.ItemReferenceOK) throw new InvalidOperationException("ConstructReference, wrong tag processing sequence");
                if (!BitStringValidator.IsValidSGTIN96BitString(tag.BitStringValue)) throw new ArgumentException("ConstructReference, Invalid bitString");

                tag.SerialReference = Convert.ToInt64(tag.BitStringValue.Substring(SERIALREFERENCE_START_POSITION, SERIALREFERENCE_LENGTH), 2);
                tag.Status = TagStatus.SerialReferenceOK;
            }
            catch (Exception)
            {
                tag.Status = TagStatus.SerialReferenceError;
                throw;
            }
        }
    }
}
