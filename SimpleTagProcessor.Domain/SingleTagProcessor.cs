using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTagProcessor.Domain
{
    public class SingleTagProcessor : TagProcessor, ITagProcessor
    {
        public SingleTagProcessor(ITagRepository tagRepository, ITagHexStringValidator tagStringValidator, ITagConstructor tagConstructor)
        {
            _tagRepository = tagRepository;
            _tagStringValidator = tagStringValidator;
            _tagConstructor = tagConstructor;
        }

        public override Tag DecodeEpcTag(string epcTag)
        {
            LoadSingleTag(epcTag);
            ValidateLoadedTags();
            ConvertHexToBitTags();
            ConstructTags();
            ValidateItemReference();

            return _tags.SingleOrDefault();
        }

        private void LoadSingleTag(string singleTag)
        {
            List<Tag> singleTagList = new List<Tag>();
            Tag newTag = new Tag();
            newTag.Isvalid = false;
            newTag.HexStringValue = singleTag;
            newTag.Status = TagStatus.Loaded;
            singleTagList.Add(newTag);
            _tags = singleTagList;
        }

        public new int GetProductCount(int companyPrefix, int itemReference)
        {
            throw new NotImplementedException();
        }

        public new IEnumerable<string> ListSerialNumbersForProduct(int companyPrefix, int itemReference)
        {
            throw new NotImplementedException();
        }

        public new IEnumerable<string> GetAllInvalidTags()
        {
            throw new NotImplementedException();
        }
    }
}
