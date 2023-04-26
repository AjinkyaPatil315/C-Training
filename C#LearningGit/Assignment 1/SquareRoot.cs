namespace Training_C_.Exercise
{
    public class SquareRoot
    {

        public void findSquareRoot(double squareValue )
        { 
                double x = squareValue;
                double y = 1;
                double precision = 0.000001;

                while (x - y > precision)
                {
                    x = (x + y) / 2;
                    y = squareValue / x;
                }

                Console.WriteLine("Square Root of the "+ squareValue + " = "+ x);
            }

        }
}
