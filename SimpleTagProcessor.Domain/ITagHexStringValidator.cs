namespace SimpleTagProcessor.Domain
{
    public interface ITagHexStringValidator
    {
        bool IsValidTagHexString(string tagString);
    }
}