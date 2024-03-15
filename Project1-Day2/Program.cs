// loops , conditions , operators- > Arithmatical , Relational == 
// what is a namespace 
// header files , string.h, stdio.h
// namespace > logical collection of related classes

// system
// # include <string.h>
// using namespace

// system namespace has classes , Console, Convert, Byte, Int16
using System;
using System.Text;
using System.IO;
using System.Collections;


namespace ns2
{
    class Program
    {

    }
    class P2
    {

    }
}
namespace Namespace_HR
{
    class Employee
    {

    }
    class Salary
    {

    }
    class Attendance
    {

    }
}
namespace Project1_Day2

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int data = Convert.ToInt32(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            string name = Console.ReadLine();   
            decimal salary = Convert.ToDecimal(Console.ReadLine()); 

            data = Int32.Parse(Console.ReadLine());
            c = char.Parse(Console.ReadLine());
            salary = Decimal.Parse(Console.ReadLine());



            int sum = 0;
            // Sum of 10 numbers
            //sum = SumOfAllNumbers();
            //Console.WriteLine($"Sum of SumOfAllNumbers is {sum}");
            //sum = GetSumOfPostiveNumbersOnly();
            //Console.WriteLine($"Sum of GetSumOfPostiveNumbersOnly is {sum}");
            Console.WriteLine("Enter character");
            char c = Convert.ToChar(Console.ReadLine());
            string res = CheckCharacter(c);
            Console.WriteLine(res);
            StringFunctions();
        }

        static int SumOfAllNumbers()
        {
            int num;
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("ENter Number");
                num = SByte.Parse(Console.ReadLine());
                sum += num;
            }
            return sum;
        }

        static int GetSumOfPostiveNumbersOnly()
        {
            int num;
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter Num");
                num = SByte.Parse(Console.ReadLine());
                if (num < 0) continue;
                else if (num == 0) break;
                sum += num;
            }
            return sum;
        }

        static string CheckCharacter(char c)
        { // ASCII values
            //65 - 97  A-Z
            // 
            c = Char.ToLower(c);
            //c.ToString().ToUpper();
            string vowels = "aeiou";
            if (vowels.Contains(c))
                return "vowel";
            //if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            //    return "Its a vowel";
            else if (c >= 'a' && c <= 'z')
                return "Consonant";
            //else if (c >= '0' && c <= '9')
            else if (Char.IsDigit(c))
                return "Integer";
            else
                return "Sp character";

        }

        static void StringFunctions()
        {
            string sentence = "This is a book No of C# & No is 9097";
            Console.WriteLine($"No of charcaters are {sentence.Length}");
            Console.WriteLine($"Sen in uppercase is {sentence.ToUpper()}");
            Console.WriteLine($"Sen in loweecase is {sentence.ToLower()}");
            char c = 'a';
            int pos = sentence.IndexOf(c);
            Console.WriteLine($"Char {c} in {sentence} is at {pos} position");
            Console.WriteLine(sentence.Insert(0, "Hello")); //Insert substring into string
            int lastpos = sentence.LastIndexOf(c);
            Console.WriteLine($"Char {c} in {sentence} is at {lastpos} position");
            Console.WriteLine(String.Concat("Hello" , " Deepak"));
            Console.WriteLine(String.Compare("B", "B"));

            Console.WriteLine(sentence.Remove(5));

            Console.WriteLine(sentence.Replace('e', 'i'));
            // Split a string into string array
            string[] array_char = sentence.Split(new char[] { ' ' });
            for(int i=0;i<array_char.Length;i++)
            {
                Console.WriteLine(array_char[i]);
            }


        }
    }
}