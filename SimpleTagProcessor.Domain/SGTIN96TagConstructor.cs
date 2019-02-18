using System;

namespace SimpleTagProcessor.Domain
{
    public class SGTIN96TagConstructor : ITagConstructor
    {
        private const int HEADER_START_POSITION = 0;
        private const int HEADER_LENGTH = 8;
        private const int HEADER_VALID_VALUE = 48;
        private const int FILTER_START_POSITION = 8;
        private const int FILTER_LENGTH = 3;
        private const int PARTITION_START_POSITION = 11;
        private const int PARTITION_LENGTH = 3;
        private const int PARTITION_MAX_VALUE = 6;
        private const int SERIALREFERENCE_START_POSITION = 58;
        private const int SERIALREFERENCE_LENGTH = 38;

        public TagStatus InvalidCompanyPrefixItemReferencePair { get; private set; }

        public void ProcessTags(Tag tag)
        {
            SetupHeader(tag);
            SetupFilter(tag);
            SetupPartition(tag);
            SetupCompanyPrefixAndItemReference(tag);
            SetupSerialReference(tag);
        }

        private void SetupHeader(Tag tag)
        {
            try
            {
                tag.Header = Convert.ToInt32(tag.BitStringValue.Substring(HEADER_START_POSITION, HEADER_LENGTH), 2);
                if (tag.Header != HEADER_VALID_VALUE) throw new ArgumentException("Header value not valid: " + tag.Header.ToString(), "tag.Header");
            }
            catch (Exception)
            {
                tag.Status = TagStatus.InvalidFilterValue;
                throw;
            }
        }

        private void SetupFilter(Tag tag)
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

        private void SetupPartition(Tag tag)
        {
            try
            {
                tag.Partition = Convert.ToInt32(tag.BitStringValue.Substring(PARTITION_START_POSITION, PARTITION_LENGTH), 2);
                if (tag.Partition > PARTITION_MAX_VALUE)
                {
                    throw new ArgumentException("Parititon value out of range", "Partition");
                }
            }
            catch (Exception)
            {
                tag.Status = TagStatus.InvalidPartitionValue;
                throw;
            }
        }

        private void SetupCompanyPrefixAndItemReference(Tag tag)
        {
            try
            {
                SGTIN96CompanyPrefixItemReferenceConstructor companyPrefixItemReferenceConstructor = new SGTIN96CompanyPrefixItemReferenceConstructor(tag.BitStringValue, tag.Partition);
                tag.CompanyPrefix = companyPrefixItemReferenceConstructor.GetCompanyPrefixValue();
                tag.ItemReference = companyPrefixItemReferenceConstructor.GetItemReferenceValue();
            }
            catch (Exception)
            {
                tag.Status = InvalidCompanyPrefixItemReferencePair;
                throw;
            }
        }

        private void SetupSerialReference(Tag tag)
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