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
                TagProcessor tagProcessor = new TagProcessor(new InMemoryTagRepository(), new SGTIN96STagHexStringValidator(), new SGTIN96TagConstructor());

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
            catch (Exception)
            {
                //TODO Logging unhandled exceptions
                throw;
            }
        }
    }
}