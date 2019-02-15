using System;

namespace SimpleTagProcessor.Data
{
    public class TextFileTagRepository : ITagRepository
    {
        private readonly string _tagSource;

        public TextFileTagRepository(string tagSource)
        {
            _tagSource = tagSource;
        }
    }
}
