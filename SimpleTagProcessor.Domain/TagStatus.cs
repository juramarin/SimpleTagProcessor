namespace SimpleTagProcessor.Domain
{
    public enum TagStatus
    {
        UnprocessedTag,
        ConvertedToBit,
        Constructed,
        ValidTag,
        InvalidHEXValue,
        InvalidConstruction,
        InvalidCompanyPrefix,
        InvalidItemReference
    }
}