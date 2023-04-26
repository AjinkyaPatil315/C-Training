namespace Training_C_.Exercise
{
    public class Fibonacci
    {

        public void findFibonacciSeries(int lowerLimit, int upperLimit)
        {

            int num1 = 0, num2 = 1, sum = 0;
            Console.WriteLine("Fibo series : ");

            while (sum < upperLimit)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;


                if (sum >= lowerLimit && sum <= upperLimit)
                {
                    Console.Write(sum + " ");
                }

            }
            Console.WriteLine("\n");
        }
    }
}
