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
                TagProcessorFactory tagProcessorfactor = new TagProcessorFactory();

                //TODO copy tags.txt to a custom directory and uncomment code below otherwise, use default in-memory tags
                IBatchTagProcessor tagProcessor = tagProcessorfactor.GetBatchTagProcessor(TagType.SGTIN_96, "C:\\tmp\\tags.txt");

                //Using default in-memory tags
                //IBatchTagProcessor tagProcessor = tagProcessorfactor.GetBatchTagProcessor(TagType.SGTIN_96);

                // 69124   Mondelēz International,  1253252 Milka Oreo
                int companyPrefix = 69124;
                int itemReference = 1253252;

                int numberOfMilkeOreos = tagProcessor.GetProductCount(companyPrefix, itemReference);
                Console.WriteLine("There are {0} Milka Oreos.", numberOfMilkeOreos);

                Console.WriteLine("Milka Oreo list");
                IEnumerable<string> milkaOreos = tagProcessor.ListSerialNumbersForProduct(companyPrefix, itemReference);
                foreach (var item in milkaOreos)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Invalid Tag list");
                IEnumerable<string> invalidTags = tagProcessor.GetAllInvalidTags();
                foreach (var tag in invalidTags)
                {
                    Console.WriteLine(tag);
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}