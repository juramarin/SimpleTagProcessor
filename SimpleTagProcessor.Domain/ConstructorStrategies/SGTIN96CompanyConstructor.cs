﻿using System;

namespace SimpleTagProcessor.Domain.ConstructorStrategies
{
    public static class SGTIN96CompanyConstructor
    {
        private const int COMPANY_PREFIX_START_POSITION = 14;

        private static int GetCompanyBitLength(int partitionValue)
        {
            switch (partitionValue)
            {
                case 0:
                    return 40;

                case 1:
                    return 37;

                case 2:
                    return 34;

                case 3:
                    return 30;

                case 4:
                    return 27;

                case 5:
                    return 24;

                case 6:
                    return 20;

                default:
                    throw new ArgumentException("Partition value must be between 0 and 6");
            }
        }

        public static void ConstructCompanyPrefix(Tag tag)
        {
            try
            {
                tag.CompanyPrefix = GetCompanyPrefixValue(tag.Partition, tag.BitStringValue);
            }
            catch (Exception)
            {
                tag.Status = TagStatus.InvalidCompanyPrefix;
                throw;
            }
        }

        private static long GetCompanyPrefixValue(int partitionValue, string bitStringValue)
        {
            int companyBitLength = GetCompanyBitLength(partitionValue);
            long result = Convert.ToInt64(bitStringValue.Substring(COMPANY_PREFIX_START_POSITION, companyBitLength), 2);
            return result;
        }
    }
}