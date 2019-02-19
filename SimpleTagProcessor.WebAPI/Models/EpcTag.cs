using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTagProcessor.WebAPI.Models
{
    public class EpcTag
    {
        public string Version { get; set; }
        public string TagStatus { get; set; }
        public EpcTagMetadata Tag { get; set; }
        public EpcTagValues TagValues { get; set; }
    }
}
