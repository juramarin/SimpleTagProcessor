using SimpleTagProcessor.Domain;

namespace SimpleTagProcessor.Data
{
    public interface ITagProcessorFactory
    {
        IBatchTagProcessor GetBatchTagProcessor(TagType tagType);

        ISingleTagProcessor GetSingleTagProcessor(TagType tagType);
    }
}