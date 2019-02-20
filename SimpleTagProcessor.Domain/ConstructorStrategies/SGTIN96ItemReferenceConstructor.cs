using SimpleTagProcessor.Common;
using System;

namespace SimpleTagProcessor.Domain.ConstructorStrategies
{
    public static class SGTIN96ItemReferenceConstructor
    {
        public static void ConstructItemReference(Tag tag)
        {
            try
            {
                if (tag.Status != TagStatus.CompanyPrefixOK) throw new InvalidOperationException("ConstructItemReference, wrong tag processing sequence");
                if (!BitStringValidator.IsValidSGTIN96BitString(tag.BitStringValue)) throw new ArgumentException("ConstructItemReference, Invalid bitString");

                var itemReferenceStartPosition = GetItemReferenceStartPosition(tag.Partition);
                var itemReferenceLength = GetItemReferenceLength(tag.Partition);

                tag.ItemReference = Convert.ToInt32(tag.BitStringValue.Substring(itemReferenceStartPosition, itemReferenceLength), 2);
                tag.Status = TagStatus.ItemReferenceOK;
            }
            catch (Exception)
            {
                tag.Status = TagStatus.ItemReferenceError;
                throw;
            }
        }

        private static int GetItemReferenceStartPosition(int partitionValue)
        {
            switch (partitionValue)
            {
                case 0:
                    return 54;

                case 1:
                    return 51;

                case 2:
                    return 48;

                case 3:
                    return 44;

                case 4:
                    return 41;

                case 5:
                    return 38;

                case 6:
                    return 34;

                default:
                    throw new ArgumentException("Partition value must be between 0 and 6");
            }
        }

        private static int GetItemReferenceLength(int partitionValue)
        {
            switch (partitionValue)
            {
                case 0:
                    return 4;

                case 1:
                    return 7;

                case 2:
                    return 10;

                case 3:
                    return 14;

                case 4:
                    return 17;

                case 5:
                    return 20;

                case 6:
                    return 24;

                default:
                    throw new ArgumentException("Partition value must be between 0 and 6");
            }
        }
    }
}