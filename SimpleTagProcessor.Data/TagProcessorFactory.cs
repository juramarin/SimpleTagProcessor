using SimpleTagProcessor.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTagProcessor.Data
{
    public class TagProcessorFactory : ITagProcessorFactory
    {
        public ITagProcessor GetTagProcessor (TagType tagType)
        {
            ITagProcessor tagProcessor;

            switch (tagType)
            {
                case TagType.SGTIN_64:
                    throw new NotImplementedException();

                case TagType.SGTIN_96:
                    tagProcessor = new TagProcessor(new InMemoryTagRepository(), new SGTIN96STagHexStringValidator(), new SGTIN96TagConstructor());
                    break;
                case TagType.SGTIN_198:
                    throw new NotImplementedException();

                default:
                    throw new NotImplementedException();
            }

            return tagProcessor;
        }

        public ITagProcessor GetSingleTagProcessor(TagType tagType)
        {
            ITagProcessor tagProcessor;

            switch (tagType)
            {
                case TagType.SGTIN_64:
                    throw new NotImplementedException();

                case TagType.SGTIN_96:
                    tagProcessor = new SingleTagProcessor(new InMemoryTagRepository(), new SGTIN96STagHexStringValidator(), new SGTIN96TagConstructor());
                    break;
                case TagType.SGTIN_198:
                    throw new NotImplementedException();

                default:
                    throw new NotImplementedException();
            }

            return tagProcessor;
        }
    }
}
