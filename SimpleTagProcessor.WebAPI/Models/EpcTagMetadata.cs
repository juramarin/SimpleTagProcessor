using SimpleTagProcessor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTagProcessor.WebAPI.Models
{
    public class EpcTagMetadata
    {
        public string EpcHex { get; set; }
        public string EpcBin { get; set; }
        public string TagScheme { get; set; }
    }
}
