using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalInches
{
    // StackOverflow 사이트에서 참고함 (Autho : amorenojr)
    // https://stackoverflow.com/questions/502021/how-do-i-round-a-decimal-to-a-specific-fraction-in-c
    public static class DoubleExtension
    {
        /// <summary>
        /// Rounds the value to the nearest increment. 
        /// Assumes mid-point rounding, value >= 0.5 rounds up, value < 0.5 rounds down.
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="increment">Enter the increment value to round toward.</param>
        /// <returns>Returns the value rounded to the nearest increment value.</returns>
        public static double RoundToNearest(this double Value, double increment)
        {
            // Returning the value rounded to the nearest increment value.
            return Math.Round(Value * Math.Pow(increment, -1), 0) * increment;
        }
        /// <summary>
        /// Rounds down the value to the nearest increment. 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="increment">Enter the increment value to round down toward.</param>
        /// <returns>Returns the value rounded down to the nearest increment value.</returns>
        public static double FloorToNearest(this double Value, double increment)
        {
            // Returning the value rounded down to the nearest increment value.
            return Math.Floor(Value * Math.Pow(increment, -1)) * increment;
        }
        /// <summary>
        /// Rounds up the value to the nearest increment. 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="increment">Enter the increment value to round up toward.</param>
        /// <returns>Returns the value rounded up to the nearest increment value.</returns>
        public static double CeilingToNearest(this double Value, double increment)
        {
            // Returning the value rounded up to the nearest increment value.
            return Math.Ceiling(Value * Math.Pow(increment, -1)) * increment;
        }
        /// <summary>
        /// Rounds the value down to the nearest imperial fractional increment
        /// and converts the value into an Inch-Fraction (IF) string. 
        /// Note: Assumes value is in inches and does not convert to Feet-Inch-Fraction (FIF)
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="maxDenominator">Enter the maximum denominator to round toward (i.e. 1/16 --> 16)</param>
        /// <returns>Returns the value rounded down to the nearest increment value based on the maxDenominator.</returns>
        public static string FloorToInchFraction(this double Value, int maxDenominator)
        {
            // Returning the rounded value converted into an Inch-Fraction (IF) string.
            return Value.FloorToNearest(Math.Pow(maxDenominator, -1)).ToInchFraction(maxDenominator);
        }

        /// <summary>
        /// Rounds the value up to the nearest imperial fractional increment
        /// and converts the value into an Inch-Fraction (IF) string. 
        /// Note: Assumes value is in inches and does not convert to Feet-Inch-Fraction (FIF)
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="maxDenominator">Enter the maximum denominator to round toward (i.e. 1/16 --> 16)</param>
        /// <returns>Returns the value rounded up to the nearest increment value based on the maxDenominator.</returns>
        public static string CeilingToInchFraction(this double Value, int maxDenominator)
        {
            // Returning the rounded value converted into a fraction string.
            return Value.CeilingToNearest(Math.Pow(maxDenominator, -1)).ToInchFraction(maxDenominator);
        }

        /// <summary>
        /// Rounds the value to the nearest increment value based on the maximum denominator specified.
        /// Assumes mid-point rounding, value >= 0.5 rounds up, value < 0.5 rounds down.
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="maxDenominator">Enter the maximum denominator to round toward (i.e. 1/16 --> 16)</param>
        /// <returns>Returns the value rounded to the nearest increment value based on the maxDenominator.</returns>
        public static string ToInchFraction(this double Value, int maxDenominator)
        {
            // Calculating the nearest increment of the value
            // argument based on the denominator argument.
            double incValue = Value.RoundToNearest(Math.Pow(maxDenominator, -1));

            // Identifying the whole number of the argument value.
            int wholeValue = (int)Math.Truncate(incValue);

            // Calculating the remainder of the argument value and the whole value.
            double remainder = incValue - wholeValue;

            // Checking for the whole number case and returning if found.
            if (remainder == 0.0) { return wholeValue.ToString() + (char)34; }

            // Iterating through the exponents of base 2 values until the
            // maximum denominator value has been reached or until the modulus
            // of the divisor.
            for (int i = 1; i < (int)Math.Log(maxDenominator, 2) + 1; i++)
            {
                // Calculating the denominator of the current iteration
                double denominator = Math.Pow(2, i);

                // Calculating the divisor increment value
                double divisor = Math.Pow(denominator, -1);

                // Checking if the current denominator evenly divides the remainder
                if ((remainder % divisor) == 0.0) // If, yes
                {
                    // Calculating the numerator of the remainder 
                    // given the calculated denominator
                    int numerator = Convert.ToInt32(remainder * denominator);

                    // Returning the resulting string from the conversion.
                    return (wholeValue > 0 ? wholeValue.ToString() + "-" : "") + numerator.ToString() + "/" + ((int)denominator).ToString() + (char)34;
                }
            }

            // Returns Error if something goes wrong.
            return "Error";
        }
    }
}
