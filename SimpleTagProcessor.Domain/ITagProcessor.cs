using System.Collections.Generic;

namespace SimpleTagProcessor.Domain
{
    public interface ITagProcessor
    {
        int GetProductCount(int companyPrefix, int itemReference);
        Tag DecodeEpcTag(string epcTag);

        IEnumerable<string> GetAllInvalidTags();
        IEnumerable<string> ListSerialNumbersForProduct(int companyPrefix, int itemReference);
    }
}