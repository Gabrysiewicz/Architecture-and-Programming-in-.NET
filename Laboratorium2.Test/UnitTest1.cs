using Xunit;

namespace Laboratorium2.Test
{
    public class UnitTest1
    {
        [Fact]
        public void FormatUsdPrice_ProperFormat_ShouldReturnProperString()
        {
            var data = 0.05;
            var result = MyFormatter.FormatUsdPrice(data);
            Assert.StartsWith("$", result);
            Assert.Contains(".", result);
        }

        [Fact]
        public void FormatUsdPrice_ProperFormat_ShouldReturnProperString2()
        {
            var data = 0.05;
            var result = MyFormatter.FormatUsdPrice(data);
            Assert.StartsWith("$", result);
            Assert.Contains(".", result);
            Assert.EndsWith("05", result);
        }

        [Fact]
        public void FormatUsdPrice_ProperFormat_ShouldReturnFalseString3()
        {
            var data = 0.06;
            var result = MyFormatter.FormatUsdPrice(data);
            Assert.StartsWith("$", result);
            Assert.Contains(".", result);
            Assert.False(result.EndsWith("05"));
        }
    }
}