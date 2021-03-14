using Xunit;

namespace AxelCreations.Validators.LuhnValidator.Tests
{
    public class PersonalIDTests
    {
        [Fact]
        public void PersonalIDIsValid()
        {
            bool isValid = Validate.PersonalID("001-1285166-2");

            Assert.True(isValid, "This personal ID card is valid");
        }

        [Fact]
        public void PersonalIDIsInvalid()
        {
            bool isValid = Validate.PersonalID("8581-0000000-1");

            Assert.False(isValid, "This is not a valid personal ID");
        }
    }
}
