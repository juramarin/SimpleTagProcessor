using SimpleTagProcessor.Data;

namespace SimpleTagProcessor.Domain
{
    public class TagProcessor
    {
        private readonly ITagRepository _tagRepository;

        public TagProcessor(string tagSource) : this(new TextFileTagRepository(tagSource))
        {
        }

        public TagProcessor(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
    }
}