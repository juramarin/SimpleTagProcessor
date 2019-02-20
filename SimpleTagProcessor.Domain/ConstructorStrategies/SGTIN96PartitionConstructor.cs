using SimpleTagProcessor.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTagProcessor.Domain.ConstructorStrategies
{
    public static class SGTIN96PartitionConstructor
    {
        private const int PARTITION_START_POSITION = 11;
        private const int PARTITION_LENGTH = 3;
        private const int PARTITION_MAX_VALUE = 6;

        public static void ConstructPartition(Tag tag)
        {
            try
            {
                if (tag.Status != TagStatus.FilterValueOK) throw new InvalidOperationException("ConstructPartition, wrong tag processing sequence");
                if (!BitStringValidator.IsValidSGTIN96BitString(tag.BitStringValue)) throw new ArgumentException("ConstructPartition, Invalid bitString");

                tag.Partition = Convert.ToInt32(tag.BitStringValue.Substring(PARTITION_START_POSITION, PARTITION_LENGTH), 2);
                tag.Status = TagStatus.PartitionValueOK;

                if (tag.Partition > PARTITION_MAX_VALUE)
                {
                    throw new ArgumentException("Parititon value out of range", "Partition");
                }
            }
            catch (Exception)
            {
                tag.Status = TagStatus.PartitionValueError;
                throw;
            }
        }
    }
}
