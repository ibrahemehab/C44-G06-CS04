using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Write a program that takes a number from the user then print yes if that
            //number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("enter a number :");
            //int number = int.Parse(Console.ReadLine());
            //bool isdivisble = number % 3 == 0 && number % 4 == 0;
            //if (isdivisble)
            //    Console.WriteLine("yes");
            //else
            //    Console.WriteLine("no");
            #endregion
            #region q2
            //Write a program that allows the user to insert an integer then print
            //negative if it is negative number otherwise print positive.
            Console.WriteLine("enter a number :");
            double number = double.Parse(Console.ReadLine());
            bool isnegative = number < 0;
            bool ispositive = number > 0;
            if (isnegative)
                Console.WriteLine("negative");
            else if (ispositive)
                Console.WriteLine("positive");
            else
                Console.WriteLine("not valid");
            #endregion
        }
    }
}
