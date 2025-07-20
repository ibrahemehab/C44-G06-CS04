using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection.Metadata;
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
            //Console.WriteLine("enter a number :");
            //double number = double.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //    Console.WriteLine($"number {number} is even");
            //else
            //    Console.WriteLine($"number {number} is odd");
            #endregion
            #region q5 
            //Write a program that takes character from the user then if it is a vowel
            //chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //Console.WriteLine("enter a character :");
            //char character = char.Parse(Console.ReadLine());
            //char ch = char.ToLower(character);
            //if (char.IsLetter(character) == false)
            //    Console.WriteLine("please enter an caracter");
            //else if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("constant");

            #endregion
            #region q6
            //Write a program that allows the user to insert an integer then print all
            //numbers between 1 to that number.
            //Console.WriteLine("enter a number :");
            //int number2 = int.Parse(Console.ReadLine());
            //if (number2 < 1)
            //    Console.WriteLine("please enter positive number");
            //for (int i = 1; i <= number2; i++)
            //    Console.WriteLine(i);

            #endregion
            #region q7
            //Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12.
            //Console.WriteLine("enter a number ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    int result = 0;
            //    result = number * i;
            //    Console.WriteLine(result);
            //}

            #endregion
            #region q8
            //Write a program that allows to user to insert number 
            //then print all even numbers between 1 to this number
            //Console.WriteLine("enter a number ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 2; i < number; ++i)
            //{
            //    Console.WriteLine(i);
            //    ++i;
            //}
            #endregion
            #region q9 
            //Write a program that takes two integers then prints the power.
            //Console.WriteLine("enter the number ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the power ");
            //int power = int.Parse(Console.ReadLine());
            //int powercalc = 1 ;
            //for (int i = 1; i <= power; i++)
            //{
            //     powercalc *= number ;
            //}
            //Console.WriteLine(powercalc);


            #endregion
            #region q10
            //Write a program to enter marks of five subjects and calculate 
            //total,average and percentage.
            //int sum = 0;
            //int count = 0;
            //int total = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"enter number{i} ");
            //    int number = int.Parse(Console.ReadLine());
            //    sum += number;
            //    count++;
            //    total += 100;
            //}
            //int average = sum / count;
            //double percentage = ((double)sum / total) * 100;
            //Console.WriteLine($"sum is {sum} ");
            //Console.WriteLine($"average is {average} ");
            //Console.WriteLine($"percentage is {percentage} ");

            #endregion
            #region q11
            //Write a program to input the month number and print the number of days in
            //that month.
            //Console.WriteLine("enter the month number");
            //int month = int.Parse(Console.ReadLine());
            //if (month == 4 || month == 6 || month == 9 || month == 11)
            //    Console.WriteLine($"the number of days in month{month}  is 30 day");
            //else if (month == 2)
            //    Console.WriteLine($"the number of days in month{month}  is 29 day");
            //else
            //    Console.WriteLine($"the number of days in month{month}  is 31 day");

            #endregion
            #region q12
            //Write a program to create a Simple Calculator.
            //Console.WriteLine("enter the first number :");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the second number :");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the operator :");
            //string operators = Console.ReadLine();
            //if (operators == "+")
            //    Console.WriteLine("the sum is :" + (num1 + num2) );
            //else if (operators == "-")
            //    Console.WriteLine("the substract is :" + (num1 - num2));
            //else if (operators == "*")
            //    Console.WriteLine("the multiple is :" + (num1 * num2));
            //else if (operators == "/")
            //    Console.WriteLine("the divison is :" + (num1 / num2));
            //else
            //    Console.WriteLine($"in valid operator{operators}");
            #endregion
            #region q13
            //Write a program to allow the user to enter a string and print the REVERSE
            //of it.
            Console.WriteLine("enter the string");
            string message = Console.ReadLine();
            string message3 = "";
            for (int i = (message.Length - 1); i >= 0; i--)
            {
                message3 += message.Substring(i , 1);
            }
            Console.WriteLine(message3);
            #endregion





        }
    }
}
