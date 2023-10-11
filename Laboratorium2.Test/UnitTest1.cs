using Xunit;

namespace Laboratorium2.Test
{
    public class UnitTest1
    {
        [Fact]
        public void FormatUsdPrice_ProperFormat_ShouldReturnProperString()
        {
            decimal data = 0.05M;
            string result = MyFormatter.FormatUsdPrice(data);
            Assert.StartsWith("$", result);
            Assert.Contains(".", result);
        }

        [Fact]
        public void FormatUsdPrice_ProperFormat_ShouldReturnProperString2()
        {
            decimal data = 0.05M;
            string result = MyFormatter.FormatUsdPrice(data);
            Assert.StartsWith("$", result);
            Assert.Contains(".", result);
            Assert.EndsWith("05", result);
        }

        [Fact]
        public void FormatUsdPrice_ProperFormat_ShouldReturnFalseString3()
        {
            decimal data = 0.05M;
            string result = MyFormatter.FormatUsdPrice(data);
            Assert.StartsWith("$", result);
            Assert.Contains(".", result);
            Assert.False(result.EndsWith("06"));
        }

        [Fact]
        public void FormatUsdPrice_ProperFormat_ShouldReturnTrueString4()
        {
            decimal data = .05M;
            string result = MyFormatter.FormatUsdPrice(data);
            Assert.StartsWith("$0", result);
            Assert.Contains(".", result);
            Assert.EndsWith("05", result);
        }

        [Fact]
        public void FormatUsdPrice_ProperFormat_ShouldReturnTrueString5()
        {
            decimal data = Convert.ToDecimal(.0123);
            string result = MyFormatter.FormatUsdPrice(data);
            Assert.StartsWith("$0", result);
            Assert.Contains(".", result);
            Assert.EndsWith("01", result);
        }
        [Fact]
        public void FormatUsdPrice_ProperFormat_ShouldReturnTrueString6()
        {
            decimal data = Convert.ToDecimal(1.234);
            string result = MyFormatter.FormatUsdPrice(data);
            Assert.StartsWith("$1", result);
            Assert.Contains(".", result);
            Assert.EndsWith("23", result);
        }
    }
}