namespace SimpleTagProcessor.Domain
{
    public enum TagStatus
    {
        Loaded,

        ValidStringFormatOK,
        ValidStringFormatError,

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