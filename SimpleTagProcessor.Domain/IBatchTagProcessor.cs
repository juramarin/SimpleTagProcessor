using System.Collections.Generic;

namespace SimpleTagProcessor.Domain
{
    public interface IBatchTagProcessor
    {
        int GetProductCount(int companyPrefix, int itemReference);

        IEnumerable<string> GetAllInvalidTags();

        IEnumerable<string> ListSerialNumbersForProduct(int companyPrefix, int itemReference);
    }
}