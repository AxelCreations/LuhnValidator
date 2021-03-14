using Xunit;

namespace AxelCreations.Validators.LuhnValidator.Tests
{
    public class CreditCardsTests
    {
        [Fact]
        public void CreditCardIsValid()
        {
            bool isValid = Validate.CreditCard("4000-0012-3456-7899");

            Assert.True(isValid, "This credit card is valid");
        }

        [Fact]
        public void CreditCardIsInvalid()
        {
            bool isValid = Validate.CreditCard("5000-0012-3456-7899");

            Assert.False(isValid, "This is not a valid credit card");
        }
    }
}
