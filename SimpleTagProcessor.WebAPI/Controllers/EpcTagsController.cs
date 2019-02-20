using Microsoft.AspNetCore.Mvc;
using SimpleTagProcessor.Data;
using SimpleTagProcessor.Domain;
using SimpleTagProcessor.WebAPI.Models;
using System;
using System.Collections.Generic;

namespace SimpleTagProcessor.WebAPI.Controllers
{
    [Route("api/epctags")]
    [ApiController]
    public class EpcTagsController : ControllerBase
    {
        private readonly ITagProcessorFactory _tagProcessorFactory;
        private readonly ISingleTagProcessor _tagProcessor;

        public EpcTagsController(ITagProcessorFactory tagProcessorFactory)
        {
            _tagProcessorFactory = tagProcessorFactory;
            _tagProcessor = _tagProcessorFactory.GetSingleTagProcessor(TagType.SGTIN_96);
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "versions", "SGTIN-96" };
        }

        [HttpGet("epchex/{singleTag}")]
        public ActionResult<string> Get(string singleTag)
        {
            if (string.IsNullOrWhiteSpace(singleTag)) return NotFound();

            try
            {
                Tag tag = _tagProcessor.DecodeEpcTag(singleTag);
                if (tag == null) return NotFound();
                if (tag.Status != TagStatus.TagOK)
                {
                    return NotFound(CreateEpcTag(tag));
                }

                EpcTag epcTag = CreateEpcTag(tag);
                return Ok(epcTag);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        private EpcTag CreateEpcTag(Tag tag)
        {
            EpcTag epcTag = new EpcTag();
            epcTag.Version = "1.0.0";
            epcTag.TagStatus = tag.Status.ToString();
            epcTag.Tag = new EpcTagMetadata()
            {
                EpcHex = tag.HexStringValue,
                EpcBin = tag.BitStringValue,
                TagScheme = tag.Type.ToString(),
            };

            epcTag.TagValues = new EpcTagValues()
            {
                Filter = tag.Filter,
                Partition = tag.Partition,
                CompanyPrefix = tag.CompanyPrefix,
                ItemReference = tag.ItemReference,
                SerialReference = tag.SerialReference
            };
            return epcTag;
        }
    }
}