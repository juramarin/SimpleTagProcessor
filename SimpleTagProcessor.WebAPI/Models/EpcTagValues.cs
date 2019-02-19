using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTagProcessor.WebAPI.Models
{
    public class EpcTagValues
    {
        public int Filter { get; set; }
        public int Partition { get; set; }
        public long CompanyPrefix { get; set; }
        public int ItemReference { get; set; }
        public long SerialReference { get; set; }
    }
}
