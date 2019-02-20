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

        HeaderValueError,
        HeaderValueOK,

        FilterValueError,
        FilterValueOK,

        PartitionValueError,
        PartitionValueOK,

        CompanyPrefixError,
        CompanyPrefixOK,

        ItemReferenceError,
        ItemReferenceOK,

        SerialReferenceError,
        SerialReferenceOK,
    }
}