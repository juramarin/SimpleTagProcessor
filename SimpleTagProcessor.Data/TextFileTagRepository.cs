using SimpleTagProcessor.Domain;
using System;
using System.Collections.Generic;

namespace SimpleTagProcessor.Data
{
    public class TextFileTagRepository : ITagRepository
    {
        private const string _fileName = "tags.txt";

        public TextFileTagRepository()
        {
        }

        public IEnumerable<Tag> LoadTags()
        {
            throw new NotImplementedException();
        }
    }
}