using SimpleTagProcessor.Domain;
using System.Collections.Generic;
using System.IO;

namespace SimpleTagProcessor.Data
{
    public class TextFileTagRepository : ITagRepository
    {
        private readonly List<string> _textFileTags;

        public TextFileTagRepository(string fileName)
        {
            _textFileTags = ReadTextFileTags(fileName);
        }

        public IEnumerable<Tag> LoadTags()
        {
            List<Tag> tags = new List<Tag>();
            foreach (var tag in _textFileTags)
            {
                Tag newTag = new Tag();
                newTag.Isvalid = false;
                newTag.HexStringValue = tag;
                newTag.Status = TagStatus.Loaded;
                tags.Add(newTag);
            }
            return tags;
        }

        private List<string> ReadTextFileTags(string fileName)
        {
            List<string> textFileTags = new List<string>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    textFileTags.Add(line);
                    line = sr.ReadLine();
                }
            }
            return textFileTags;
        }
    }
}