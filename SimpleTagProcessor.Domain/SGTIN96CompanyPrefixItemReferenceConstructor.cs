using System;

namespace SimpleTagProcessor.Domain
{
    public class SGTIN96CompanyPrefixItemReferenceConstructor
    {
        private const int COMPANYPREFIX_AND_ITEMREFERENCE_LENGTH = 44;
        private const int BIT_STRING_TAG_LENGTH = 96;
        private const int COMPANY_PREFIX_START_POSITION = 14;

        private readonly int _partitionValue;
        private readonly string _bitStringTag;

        private int _companyPrefixLength = -1;
        private int _itemReferenceStartPosition = -1;
        private int _itemReferenceLength = -1;

        public SGTIN96CompanyPrefixItemReferenceConstructor(string bitStringTag, int partitionValue)
        {
            if (partitionValue < 0 || partitionValue > 6) throw new ArgumentException("Bad partition value");
            if (string.IsNullOrWhiteSpace(bitStringTag)) throw new ArgumentException("Bit Tag String must NOT be null or empty", "bitStringTag");
            if (bitStringTag.Length != BIT_STRING_TAG_LENGTH) throw new ArgumentException("Bit Tag String must be 96 digits", "bitStringTag");

            _partitionValue = partitionValue;
            _bitStringTag = bitStringTag;

            SetupBitsPositionsAndLengths();
        }

        private void SetupBitsPositionsAndLengths()
        {
            switch (_partitionValue)
            {
                case 0:
                    _companyPrefixLength = 40;
                    _itemReferenceStartPosition = COMPANY_PREFIX_START_POSITION + _companyPrefixLength;
                    _itemReferenceLength = 4;
                    break;

                case 1:
                    _companyPrefixLength = 37;
                    _itemReferenceStartPosition = COMPANY_PREFIX_START_POSITION + _companyPrefixLength;
                    _itemReferenceLength = 7;
                    break;

                case 2:
                    _companyPrefixLength = 34;
                    _itemReferenceStartPosition = COMPANY_PREFIX_START_POSITION + _companyPrefixLength;
                    _itemReferenceLength = 10;
                    break;

                case 3:
                    _companyPrefixLength = 30;
                    _itemReferenceStartPosition = COMPANY_PREFIX_START_POSITION + _companyPrefixLength;
                    _itemReferenceLength = 14;
                    break;

                case 4:
                    _companyPrefixLength = 27;
                    _itemReferenceStartPosition = COMPANY_PREFIX_START_POSITION + _companyPrefixLength;
                    _itemReferenceLength = 17;
                    break;

                case 5:
                    _companyPrefixLength = 24;
                    _itemReferenceStartPosition = COMPANY_PREFIX_START_POSITION + _companyPrefixLength;
                    _itemReferenceLength = 20;
                    break;

                case 6:
                    _companyPrefixLength = 20;
                    _itemReferenceStartPosition = COMPANY_PREFIX_START_POSITION + _companyPrefixLength;
                    _itemReferenceLength = 24;
                    break;

                default:
                    throw new NotImplementedException();
            }

            if (_companyPrefixLength + _itemReferenceLength != COMPANYPREFIX_AND_ITEMREFERENCE_LENGTH)
            {
                throw new ArgumentOutOfRangeException("Bad partition value");
            }
        }

        public long GetCompanyPrefixValue()
        {
            long result = Convert.ToInt64(_bitStringTag.Substring(COMPANY_PREFIX_START_POSITION, _companyPrefixLength), 2);            return result;        }

        public int GetItemReferenceValue()
        {
            int result = Convert.ToInt32(_bitStringTag.Substring(_itemReferenceStartPosition, _itemReferenceLength), 2);            return result;        }
    }
}