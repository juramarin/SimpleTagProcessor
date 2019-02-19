namespace SimpleTagProcessor.Domain
{
    public enum TagStatus
    {
        Loaded,

        TagStringFormatOK,
        TagStringFormatError,

        ConvertedToBitOK,
        ConvertedToBitError,

        ConstructedOK,
        ConstructedError,

        TagOK,

        InvalidCompanyPrefix,
        InvalidItemReference,
        InvalidFilterValue,
        InvalidPartitionValue,
        InvalidSerialReference
    }
}