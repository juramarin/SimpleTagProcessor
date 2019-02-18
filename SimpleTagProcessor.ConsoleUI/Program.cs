using SimpleTagProcessor.Data;
using SimpleTagProcessor.Domain;
using System;
using System.Collections.Generic;

namespace SimpleTagProcessor.ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                //1. read tags from custom text file
                TagProcessor tagProcessor = new TagProcessor(new InMemoryTagRepository(), new SGTIN96STagHexStringValidator(),  new SGTIN96TagConstructor());

                // 69124   Mondelēz International  1253252 Milka Oreo
                int companyPrefix = 69124;
                int itemReference = 1253252;

                int products = tagProcessor.GetProductCount(companyPrefix, itemReference);

                //IEnumerable<int> allSerialNumbersForProduct = tagProcessor.GetAllSerialNumbersForProduct(companyPrefix, itemReference);

                //IEnumerable<string> allInvalidTags = tagProcessor.GetAllInvalidTags();
            }
            catch (Exception)
            {
                //TODO Logging unhandled exceptions
                throw;
            }
        }
    }
}