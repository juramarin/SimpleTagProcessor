namespace SimpleTagProcessor.Domain
{
    public class Tag
    {
        public TagType Type { get; set; }
        public string HexStringValue { get; set; }
        public string BitStringValue { get; set; }
        public bool Isvalid { get; set; }
        public TagStatus Status { get; set; }
        public int Header { get; set; }
        public int Filter { get; set; }
        public int Partition { get; set; }
        public long CompanyPrefix { get; set; }
        public int ItemReference { get; set; }
        public long SerialReference { get; set; }
    }
}