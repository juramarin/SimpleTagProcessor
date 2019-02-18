using System.Collections.Generic;

namespace SimpleTagProcessor.Domain
{
    public interface ITagRepository
    {
        IEnumerable<Tag> LoadTags();
    }
}