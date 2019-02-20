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
                tag.SerialReference = Convert.ToInt64(tag.BitStringValue.Substring(SERIALREFERENCE_START_POSITION, SERIALREFERENCE_LENGTH), 2);
            }
            catch (Exception)
            {
                tag.Status = TagStatus.InvalidSerialReference;
                throw;
            }
        }
    }
}
