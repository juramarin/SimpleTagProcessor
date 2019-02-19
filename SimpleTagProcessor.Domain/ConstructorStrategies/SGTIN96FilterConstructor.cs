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
                tag.Filter = Convert.ToInt32(tag.BitStringValue.Substring(FILTER_START_POSITION, FILTER_LENGTH), 2);
            }
            catch (Exception)
            {
                tag.Status = TagStatus.InvalidFilterValue;
                throw;
            }
        }
    }
}
