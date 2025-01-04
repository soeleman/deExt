using DeExt;

namespace DeExtTest
{
    partial class StringUnitTest
    {
        [Theory]
#pragma warning disable xUnit1012 // Null test
        [InlineData(true, null)]
#pragma warning restore xUnit1012 
        [InlineData(true, EmptyString)]
        [InlineData(false, "One")]
        public void IsNullOrWhiteSpace(
            bool state, 
            string value)
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