using System;

namespace AxelCreations.Validators.LuhnValidator
{
    public static class Validate
    {
        // Public validator for Credit Cards
        public static bool CreditCard(string cardNumber)
        {
            return cardNumber.Length >= 16 && ValidateNumber(cardNumber);
        }

        // Public validator for Dominicans Personal Identification Number
        public static bool PersonalID(string idNumber)
        {
            return idNumber.Length >= 11 && ValidateNumber(idNumber);
        }

        // Method to perform the luhn algorithm on received number
        private static bool ValidateNumber(string number)
        {
            number = number.Replace("-", "");

            int ControlDigit = ((number.Length - 1) % 2 == 0) ? 1 : 2;
            int Sum = 0;

            foreach (char digit in number[0..^1])
            {
                int Result = int.Parse(digit.ToString()) * ControlDigit;

                Sum += (Result > 9) ?
                    int.Parse(Convert.ToString(Result)[0].ToString()) +
                    int.Parse(Convert.ToString(Result)[1].ToString()) : Result;

                ControlDigit = (ControlDigit == 2) ? 1 : 2;
            }

            return ((10 - int.Parse(Sum.ToString()[1].ToString()) == 10) ?
                0 : 10 - int.Parse(Sum.ToString()[1].ToString())) == int.Parse(number[^1].ToString());
        }
    }
}
