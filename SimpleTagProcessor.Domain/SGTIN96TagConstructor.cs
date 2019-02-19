using SimpleTagProcessor.Domain.ConstructorStrategies;

namespace SimpleTagProcessor.Domain
{
    public class SGTIN96TagConstructor : ITagConstructor
    {
        public void ConstructTag(Tag tag)
        {
            SGTIN96HeaderConstructor.ConstructHeader(tag);
            SGTIN96FilterConstructor.ConstructFilter(tag);
            SGTIN96PartitionConstructor.ConstructPartition(tag);
            SGTIN96CompanyConstructor.ConstructCompanyPrefix(tag);
            SGTIN96ItemReferenceConstructor.ConstructItemReference(tag);
            SGTIN96SerialConstructor.ConstructReference(tag);
        }
    }
}