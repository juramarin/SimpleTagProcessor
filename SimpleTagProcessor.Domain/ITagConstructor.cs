using System.Collections.Generic;

namespace SimpleTagProcessor.Domain
{
    public interface ITagConstructor
    {
        void ProcessTags(IEnumerable<Tag> tags);
    }
}