using SimpleTagProcessor.Domain;

namespace SimpleTagProcessor.Data
{
    public interface ITagProcessorFactory
    {
        ITagProcessor GetTagProcessor(TagType tagType);
    }
}