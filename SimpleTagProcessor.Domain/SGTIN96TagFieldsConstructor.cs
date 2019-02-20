using SimpleTagProcessor.Domain.ConstructorStrategies;
using System;

namespace SimpleTagProcessor.Domain
{
    public class SGTIN96TagFieldsConstructor : ITagFieldsConstructor
    {
        public void ConstructTagFields(Tag tag)
        {
            if (tag == null) throw new ArgumentException("ConstructTagFields, tag must not be null", "tag");
            if (tag.Status != TagStatus.ConvertedToBitOK) throw new ArgumentException("Tag must have status ConvertedToBitOK", "tag");

            SGTIN96HeaderConstructor.ConstructHeader(tag);
            SGTIN96FilterConstructor.ConstructFilter(tag);
            SGTIN96PartitionConstructor.ConstructPartition(tag);
            SGTIN96CompanyConstructor.ConstructCompanyPrefix(tag);
            SGTIN96ItemReferenceConstructor.ConstructItemReference(tag);
            SGTIN96SerialConstructor.ConstructReference(tag);
        }
    }
}