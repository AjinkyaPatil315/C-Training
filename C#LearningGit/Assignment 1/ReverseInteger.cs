namespace Training_C_.Exercise
{
    public class ReverseInteger
    {
        public void reverseInteger(int valueToBeReversed)
        {
            int value = valueToBeReversed;
           int reversedNumber = 0;
           while (valueToBeReversed > 0)
             {
                 int digit = valueToBeReversed % 10;
                 reversedNumber = reversedNumber * 10 + digit;
                 valueToBeReversed /= 10;
             }
         Console.WriteLine("Reversal of "+ value + " is " + reversedNumber);
            }
        }
}
