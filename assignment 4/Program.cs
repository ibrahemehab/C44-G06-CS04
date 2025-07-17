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
            Console.WriteLine("enter a number :");
            int number = int.Parse(Console.ReadLine());
            bool isdivisble = number % 3 == 0 && number % 4 == 0;
            if (isdivisble)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            #endregion
        }
    }
}
