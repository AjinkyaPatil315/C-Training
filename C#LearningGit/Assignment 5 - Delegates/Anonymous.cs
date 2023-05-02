//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Training_C_.Exercise_Day5
//{
//    public class Anonymous
//    {
//        delegate int AnonymousDelegate(int x, int y);

//        static void Main(string[] args)
//        {
//            AnonymousDelegate del = delegate (int x, int y)
//            {
//                int result = (int)Math.Pow(x, y);
//                return result;
//            };

//            int x = 10;
//            int y = 4;

//            int result = del(x, y);

//            Console.WriteLine("The Result of the Anonymous method is : " + result);


//            ReturnUpperCase up = new ReturnUpperCase();
//            Console.WriteLine(up.ConvertToUpperCase("Dham Dhoom"));


//            GreaterNumber greater = new GreaterNumber();
//            greater.IsGreaterThan(25, 35);
//            greater.IsGreaterThan(100, 35);

//            string rev = "Ajinkya".Reverse().ToString();
//            Console.WriteLine("Reverse the string using string extension : " + rev);
//        }
//    }
//}
