using System;
using System.Collections.Generic;

namespace SimpleTagProcessor.Domain
{
    public class SGTIN96TagConstructor : ITagConstructor
    {
        private const int HEADER_START_POSITION = 0;
        private const int HEADER_LENGTH = 8;
        private const int FILTER_START_POSITION = 8;
        private const int FILTER_LENGTH = 3;
        private const int PARTITION_START_POSITION = 11;
        private const int PARTITION_LENGTH = 3;
        private const int PARTITION_MAX_VALUE = 6;
        private const int SERIALREFERENCE_START_POSITION = 58;
        private const int SERIALREFERENCE_LENGTH = 38;

        public void ProcessTags(IEnumerable<Tag> tags)
        {
            foreach (var tag in tags)
            {
                SetupHeader(tag);
                SetupFilter(tag);
                SetupPartition(tag);
                SetupCompanyPrefixAndItemReference(tag);
                SetupSerialReference(tag);
                tag.Status = TagStatus.Constructed;
            }
        }

        private void SetupHeader(Tag tag)
        {
            tag.Header = Convert.ToInt32(tag.BitStringValue.Substring(HEADER_START_POSITION, HEADER_LENGTH), 2);
        }

        private void SetupFilter(Tag tag)
        {
            tag.Filter = Convert.ToInt32(tag.BitStringValue.Substring(FILTER_START_POSITION, FILTER_LENGTH), 2);
        }

        private void SetupPartition(Tag tag)
        {
            tag.Partition = Convert.ToInt32(tag.BitStringValue.Substring(PARTITION_START_POSITION, PARTITION_LENGTH), 2);
        }

        private void SetupCompanyPrefixAndItemReference(Tag tag)
        {
            SGTIN96CompanyPrefixItemReferenceConstructor companyPrefixItemReferenceConstructor = new SGTIN96CompanyPrefixItemReferenceConstructor(tag.BitStringValue, tag.Partition);
            tag.CompanyPrefix = companyPrefixItemReferenceConstructor.GetCompanyPrefixValue();
            tag.ItemReference = companyPrefixItemReferenceConstructor.GetItemReferenceValue();
        }

        private void SetupSerialReference(Tag tag)
        {
            tag.SerialReference = Convert.ToInt64(tag.BitStringValue.Substring(SERIALREFERENCE_START_POSITION, SERIALREFERENCE_LENGTH), 2);
        }

    }
}