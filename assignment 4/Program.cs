using System.Xml.Linq;
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
            //Console.WriteLine("enter a number :");
            //double number = double.Parse(Console.ReadLine());
            //bool isnegative = number < 0;
            //bool ispositive = number > 0;
            //if (isnegative)
            //    Console.WriteLine("negative");
            //else if (ispositive)
            //    Console.WriteLine("positive");
            //else
            //    Console.WriteLine("not valid");

            #endregion
            #region q3
            //Write a program that takes 3 integers from the user then 
            //prints the max element and the min element.
            //int max = int.MinValue;
            //int min = int.MaxValue;
            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine("enter number " + i);
            //    int number = int.Parse(Console.ReadLine());
            //    if ( number > max)
            //        max = number;
            //    if (number < min)
            //        min = number;
            //}
            //Console.WriteLine($"the max is {max}");
            //Console.WriteLine($"the max is {min}");
            #endregion
            #region q4 
            //Write a program that takes 3 integers from the user 
            //then prints the max element and the min element.
            Console.WriteLine("enter a number :");
            double number = double.Parse(Console.ReadLine());
            if(number%2==0)
                Console.WriteLine($"number {number} is even");
            else
                Console.WriteLine($"number {number} is odd");
            #endregion
        }
    }
}
