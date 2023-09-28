using System;

namespace ConsoleApp1
{
    public class Program
    {
        /* Functins: 
         * <Access specifier> <Return type><Method name>(parameters)
         * {Body}
         * Access specifier: whether it can be called from another class
         * public: Can be accesssed from another class
         * private: Can't be accessed from another class
         * protected: Can't be accessed by class and derived classes 
         */
        static void PrintArray(int[] intArray, string mess)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0} : {1} ", mess, k);
            }
        }

        // Arayys wth same name 
        static double DoubleIt(int x=1, int solution=2)
        {
            solution = x * 2;
            return solution;
        }

        static double DoubleIt(string x="1", string solution="2")
        {
            double dblxXY = Convert.ToDouble(x);
            double dblXSolution = Convert.ToDouble(solution);
            return dblXSolution + dblxXY;
        }


        static void Main(string[] args) // static doesnt return anything
        {
            Console.WriteLine("same array name = {0}", DoubleIt(4, 5)); // it can take int
            Console.WriteLine("same array name = {0}", DoubleIt("4", "5")); // but can take string as well 
            Console.WriteLine("Hello World");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear(); // clear the console!
            /*
            Console.Write("What is your name?");
            string name = Console.ReadLine(); // reads the input
            Console.WriteLine($"Hello {name}"); // fstring
            */
            // variables

            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            decimal decPiVal = 3.12232134241414M; // the last suphex is important
            decimal decBigNum = 3.000000000000000011M;
            double OneNumber = 123.123F; // in case of float the F at the end 
            Console.WriteLine("Dec : PI + bignum = {0}", decPiVal + decBigNum);
            //Conversion: 
            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            string strVal = dblFromStr.ToString();
            Console.WriteLine($"Data type : {strVal.GetType()}");
            double dblNum = 12.234;
            Console.WriteLine($"Integer : {(int)dblNum}"); // explicit conversion! Loosing value in this case everythign after the decimal point
            int intNum = 10;
            long longNum = intNum; // this is implicit conversion!
                                   // there is no data loss in this case
                                   // Specific output:
            Console.WriteLine("Currency : {0:c}", 23.5345);
            Console.WriteLine("pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 decimals : {0:f3}", 23.5345);
            //String funcitons 
            string randString = "This is a random string";
            Console.WriteLine("String lenght : {0}", randString.Length);
            Console.WriteLine("String contains is : {0}", randString.Contains("is"));
            Console.WriteLine("index of is : {0}", randString.IndexOf("is"));
            Console.WriteLine("remove : {0}", randString.Remove(10,6));
            Console.WriteLine("insert : {0}", randString.Insert(10,"short"));
            Console.WriteLine("replace : {0}", randString.Replace("string","sentence"));
            Console.WriteLine("----------------------------");
            Console.WriteLine("A = a : {0} ", // comparison of two string with ignoring case
                String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            string newString = String.Format("{0} saw a {1} {2} in the {3}",
                "paul", "rabbit", "eating", "field"); // replaces the numbers  
            Console.Write(newString + "\n");
            //
            int[] favNums = new int[3]; // arrays has fix spaces
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);

            string[] customers = { "bob", "sally", "Sue" };
            var employees = new[] { "mike", "paul" };
            object[] randomArray = { "paul", 45, 1.234 };
            Console.WriteLine("randomArray 0 : {0} ",
                randomArray[0].GetType);
            Console.WriteLine("array size : {0}", randomArray.Length);

            for(int j = 0; j < randomArray.Length; j++)
            {
                Console.WriteLine("arrary : {0} Value : {1}",
                    j, randomArray[j]);  
            }
            int[] randomNums = { 123,23,43};
            PrintArray(randomNums, "foreachTheMessage");
            //
            int[] numArray = { 1, 11, 23 };

            Console.Clear();


        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w =1 )
        }
    }
}