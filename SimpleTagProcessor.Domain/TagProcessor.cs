using SimpleTagProcessor.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTagProcessor.Domain
{
    public class TagProcessor : ITagProcessor
    {
        protected ITagRepository _tagRepository;
        protected ITagHexStringValidator _tagStringValidator;
        protected ITagConstructor _tagConstructor;
        protected IEnumerable<Tag> _tags;

        public TagProcessor()
        {

        }

        public TagProcessor(ITagRepository tagRepository, ITagHexStringValidator tagStringValidator, ITagConstructor tagConstructor)
        {
            _tagRepository = tagRepository;
            _tagStringValidator = tagStringValidator;
            _tagConstructor = tagConstructor;

            BatchTagProcessing();
        }


        public int GetProductCount(int companyPrefix, int itemReference)
        {
            return _tags.Where(t => t.CompanyPrefix == companyPrefix && t.ItemReference == itemReference).Count();
        }

        public IEnumerable<string> ListSerialNumbersForProduct(int companyPrefix, int itemReference)
        {
            List<string> serialNumbers = new List<string>();
            int lines = 1;
            foreach (var tag in _tags.Where(t => t.CompanyPrefix == companyPrefix && t.ItemReference == itemReference))
            {
                string product = String.Format("{4}  {0}  Company Prefix: {1}, Item Reference: {2}, Serial: {3}",
                    tag.HexStringValue, tag.CompanyPrefix, tag.ItemReference, tag.SerialReference, lines);
                serialNumbers.Add(product);
                lines++;
            }
            return serialNumbers;
        }

        public IEnumerable<string> GetAllInvalidTags()
        {
            List<string> serialNumbers = new List<string>();
            int lines = 1;
            foreach (var tag in _tags.Where(t => t.Status != TagStatus.TagOK))
            {
                string product = String.Format("{4}  {0}  Company Prefix: {1}, Item Reference: {2}, Serial: {3}",
                    tag.HexStringValue, tag.CompanyPrefix, tag.ItemReference, tag.SerialReference, lines);
                serialNumbers.Add(product);
                lines++;
            }
            return serialNumbers;
        }


        public virtual Tag DecodeEpcTag(string epcTag)
        {
            throw new NotImplementedException();
        }



        private void BatchTagProcessing()
        {
            LoadTags();
            ValidateLoadedTags();
            ConvertHexToBitTags();
            ProcessTags();
            ValidateItemReference();
        }

        private void LoadTags()
        {
            _tags = _tagRepository.LoadTags();
        }

        protected void ValidateLoadedTags()
        {
            foreach (var tag in _tags)
            {
                try
                {
                    if (_tagStringValidator.IsValidTagHexString(tag.HexStringValue))
                    {
                        tag.Status = TagStatus.TagStringFormatOK;
                    }
                    else
                    {
                        tag.Status = TagStatus.TagStringFormatError;
                    }
                }
                catch (Exception)
                {
                    tag.Status = TagStatus.TagStringFormatError;
                    Console.WriteLine("Unprocessed Tag: {0}", tag.HexStringValue);
                }
            }
        }

        protected void ConvertHexToBitTags()
        {
            foreach (var tag in _tags.Where(t => t.Status == TagStatus.TagStringFormatOK))
            {
                try
                {
                    var bitStringValue = HexBinaryConverter.HexToBinary(tag.HexStringValue);
                    tag.BitStringValue = bitStringValue;
                    tag.Status = TagStatus.ConvertedToBitOK;
                }
                catch (Exception)
                {
                    tag.Status = TagStatus.ConvertedToBitError;
                    Console.WriteLine("Not ConvertedToHex Tag: {0}", tag.HexStringValue);
                }
            }
        }

        protected void ProcessTags()
        {
            foreach (var tag in _tags.Where(t => t.Status == TagStatus.ConvertedToBitOK))
            {
                try
                {
                    _tagConstructor.ProcessTags(tag);
                    tag.Status = TagStatus.ConstructedOK;
                }
                catch (Exception)
                {
                    tag.Status = TagStatus.ConstructedError;
                    Console.WriteLine("Not Processed Tag: {0}", tag.HexStringValue);
                }
            }
        }

        protected void ValidateItemReference()
        {
            // TODO - (If needed) Added comparison of constructed Company Prefix and Item Reference with existing from InMemoryCompanyRepository
            foreach (var tag in _tags.Where(t => t.Status == TagStatus.ConstructedOK))
            {
                tag.Status = TagStatus.TagOK;
            }
        }



        private void ShowInValidtags()
        {
            int counter = 1;
            foreach (var tag in _tags.Where(t => t.Status != TagStatus.TagOK))
            {
                Console.WriteLine("{3} record: Tag: {0}, TagStatus: {1},  Bit: {2}", tag.HexStringValue, tag.Status.ToString(), tag.BitStringValue ?? "is nullish", counter);
                counter++;
            }
        }

        private void ShowValidtags()
        {
            int counter = 1;
            foreach (var tag in _tags.Where(t => t.Status == TagStatus.TagOK))
            {
                Console.WriteLine("{3} record: Valid Tag: {0}, TagStatus: {1},  Bit: {2}", tag.HexStringValue, tag.Status.ToString(), tag.BitStringValue ?? "is nullish", counter);
                counter++;
            }
        }
    }
}