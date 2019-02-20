using System;
using Xunit;

namespace SimpleTagProcessor.Domain.Tests
{
    public class SGTIN96STagHexStringValidatorTest
    {
        private SGTIN96STagHexStringValidator sut;

        public SGTIN96STagHexStringValidatorTest()
        {
            sut = new SGTIN96STagHexStringValidator();
        }

        [Theory]
        [InlineData("3074257BF7194E4000001A85")]
        [InlineData("3098D0A357783C0034E9DF74")]
        [InlineData("307ABE3665404EC00F863485")]
        [InlineData("309B1BC6D36B93C032AAD59A")]
        [InlineData("30727B26B233998003303C79")]
        [InlineData("305B747BA582600033AF5994")]
        [InlineData("30D4068B5B0A54C00D853004")]
        [InlineData("3075E4C70E27E180119FA3FC")]
        [InlineData("3082C7FD845E3500343CAD1C")]
        [InlineData("3078325EA2A9DB8003A7CACC")]
        public void IsValidTagHexString_WithValidParameters_ReturnTrue(string hexString)
        {
            bool result = sut.IsValidTagHexString(hexString);
            Assert.True(result);
        }

        [Theory]
        [InlineData("20B8D0A357783C0010954240")]
        [InlineData("F")]
        [InlineData("319B60F9A16785001A108C20")]
        [InlineData("30HB747BA582600005AE9068")]
        [InlineData("385B26AA444FE94027CE82A8")]
        [InlineData("3308482E64681EC015DE3B31")]
        [InlineData("30D4068B5B0A54C00D853004xxxxxxxx")]
        [InlineData("3075E4C70E27E180119!=C")]
        [InlineData(".082C7FD845E3500343CAD1C")]
        [InlineData("!")]
        [InlineData("ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ")]
        public void IsValidTagHexString_WithInValidParameters_ReturnFalse(string hexString)
        {
            bool result = sut.IsValidTagHexString(hexString);
            Assert.False(result);
        }

        [Theory]
        [InlineData("")]
        public void IsValidTagHexString_WithEmptyParameter_ThrowsArgumentException(string hexString)
        {
            Assert.Throws<ArgumentException>(() => sut.IsValidTagHexString(hexString));
        }
    }
}