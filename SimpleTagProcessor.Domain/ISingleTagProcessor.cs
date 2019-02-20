namespace SimpleTagProcessor.Domain
{
    public interface ISingleTagProcessor
    {
        Tag DecodeEpcTag(string epcTag);
    }
}