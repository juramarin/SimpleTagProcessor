using SimpleTagProcessor.Common;
using System;
using System.Collections.Generic;

namespace SimpleTagProcessor.Domain
{
    public class TagProcessor
    {
        private ITagRepository _tagRepository;
        private ITagHexStringValidator _tagStringValidator;
        private ITagConstructor _tagConstructor;

        private IEnumerable<Tag> _tags;

        public TagProcessor(ITagRepository tagRepository, ITagHexStringValidator tagStringValidator, ITagConstructor tagConstructor)
        {
            _tagRepository = tagRepository;
            _tagStringValidator = tagStringValidator;
            _tagConstructor = tagConstructor;

            LoadUnprocessedTags();
            ValidateUnprocessedTags();
            ProcessTags();
        }

        private void ProcessTags()
        {
            _tagConstructor.ProcessTags(_tags);
        }

        private void LoadUnprocessedTags()
        {
            _tags = _tagRepository.GetUnprocessedTags();
        }


        private void ValidateUnprocessedTags()
        {
            foreach (var unprocessedTag in _tags)
            {
                if (_tagStringValidator.IsValidTagHexString(unprocessedTag.HexStringValue))
                {
                    var bitStringValue = HexBinaryConverter.HexToBinary(unprocessedTag.HexStringValue);
                    unprocessedTag.BitStringValue = bitStringValue;
                    unprocessedTag.Status = TagStatus.ConvertedToBit;
                }
                else
                {
                    unprocessedTag.Status = TagStatus.InvalidHEXValue;
                }
            }
        }



        public int GetProductCount(int companyPrefix, int itemReference)
        {

            throw new NotImplementedException();
        }

        public IEnumerable<int> GetAllSerialNumbersForProduct(int companyPrefix, int itemReference)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllInvalidTags()
        {
            throw new NotImplementedException();
        }

        //private void ValidateTagSourceName(string tagSourceName)
        //{
        //    if (string.IsNullOrWhiteSpace(tagSourceName)) throw new ArgumentException("Tag Source Name must be entered", "tagSourceName");
        //}
    }
}