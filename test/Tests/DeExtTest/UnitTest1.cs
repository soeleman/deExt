using DeExt;
namespace DeExtTest
{
    public class StringUnitTest
    {
        [Theory]
        [InlineData(true, null)]
        [InlineData(true, "")]
        [InlineData(false, "One")]
        public void Base(bool state, string value)
        {
            if (state)
            {
                Assert.True(value.IsNullOrWhiteSpace());
            }
            else
            {
                Assert.False(value.IsNullOrWhiteSpace());
            }
        }
    }
}