using SimpleTagProcessor.Domain;
using System;

namespace SimpleTagProcessor.Data
{
    public class TagProcessorFactory : ITagProcessorFactory
    {
        public IBatchTagProcessor GetBatchTagProcessor(TagType tagType)
        {
            IBatchTagProcessor tagProcessor;

            switch (tagType)
            {
                case TagType.SGTIN_64:
                    throw new NotImplementedException();

                case TagType.SGTIN_96:
                    tagProcessor = new TagProcessor(new InMemoryTagRepository(), new SGTIN96STagHexStringValidator(), new SGTIN96TagFieldsConstructor());
                    break;

                case TagType.SGTIN_198:
                    throw new NotImplementedException();

                default:
                    throw new NotImplementedException();
            }

            return tagProcessor;
        }

        public ISingleTagProcessor GetSingleTagProcessor(TagType tagType)
        {
            ISingleTagProcessor tagProcessor;

            switch (tagType)
            {
                case TagType.SGTIN_64:
                    throw new NotImplementedException();

                case TagType.SGTIN_96:
                    tagProcessor = new TagProcessor(new SGTIN96STagHexStringValidator(), new SGTIN96TagFieldsConstructor());
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