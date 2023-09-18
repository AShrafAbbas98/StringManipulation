using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #String Manipulation 

            string firstName = "Ashraf";
            string secondName = "Abbas";

            string fullName = null;

            // 01- string.Concat(firstName, " " , secondName);

            //fullName = firstName + " " + secondName;

            //fullName = string.Concat(firstName, " ", secondName);
            //Console.WriteLine(fullName);
            //Console.ReadLine();

            //-----------------------------------------------------------------

            // 02- text.Substring(i) ==> returns part of the string

            fullName += " " +firstName ;

            //Console.WriteLine(fullName);



            string greeting = "Hello World";

            // index = 6 where W start the World string

            string worldText = greeting.Substring(6);
            //Console.WriteLine(worldText);

            string helloText = greeting.Substring(0, 5);
            //Console.WriteLine(helloText);



            //-----------------------------------------------------------------

            // 03- text.Split(','); ===> split the string whenever catch a "," ==> Returns string[] 

            string days = "I love, coding";
            char mark = 'A';
            //string[] texts = days.Split(' ');

            //foreach(string text in texts)
            //{
            //    foreach(char c in text)
            //    {
            //        Console.Write(c);
            //        Console.Write(" ");
            //        Thread.Sleep(500);
            //    }
            //    Console.Write("   ");
            //    Thread.Sleep(1000);
            //}
            //Console.Read();

            //string[] txt01 = days.Split(' ');
            //foreach(string text in txt01)
            //{
            //    Console.WriteLine(text);
            //}

            //string[] txt02 = days.Split(',');
            //foreach (string text in txt02)
            //{
            //    Console.WriteLine(text);
            //}
            //-----------------------------------------------------------------

            // 04- text.Replace("apples", "bananas");

            string fruits = "I'm eating apples";

            string newFruits = fruits.Replace("apples", "Mango");
            //Console.WriteLine(newFruits);

            //-----------------------------------------------------------------

            // 05- text.ToUpper and text.ToLower()

            string name = "Ali Ahmed is smart";

            string newName = name.ToUpper();
            //Console.WriteLine(newName);

            string newName02 = name.ToLower();
            //Console.WriteLine(newName02);

            //Console.WriteLine(name.ToLower());

            //-----------------------------------------------------------------

            // 06-text.Contains("fox"); ==> Returns bool

            string animals = "Lion running in the jungel";

            string animal02 = "Lion eats Fox";


            bool checkIfFoxExist = animal02.Contains("Fox");

            bool checkIfFoxExistSmallCase = animal02.ToLower().Contains("fox");

            //Console.WriteLine(checkIfFoxExistSmallCase);

            //-----------------------------------------------------------------

            // 07- String Interpolation ==> $"I am {age} years old." 
            int num = 5;
            //Console.WriteLine($"I saw {animals} and {animal02} {num} times");

            //-----------------------------------------------------------------

            // 08- String Formatting  ==> string.Format("Name: {0}, Score: {1}", name, score);

            //Console.WriteLine("I saw {0} and {1} {2} times", animals, animal02, num);

            //-------------------------------------------------------------------------------------

            // #Parsing

            // string =>  int

            Console.WriteLine("How old are you?");

            // Always inputs from user come as a string
            // so we need to convert it to int 
            // using int.Parse()
            string input = Console.ReadLine();
            int numFromUser = int.Parse(input);
            
            //int.TryParse(input, out numFromUser);

            Console.WriteLine(numFromUser);
            int year = 27;


            Console.WriteLine($"You entered {numFromUser}");

            // int => string

            int month = 9;

            string monthNum = month.ToString();

            //-------------------------------------------------------------------------------------

            // #Type Casting

            // 01- implicitly casting


            // 01- Explicitly casting


            //-------------------------------------------------------------------------------------

            // Array


            //-------------------------------------------------------------------------------------

            // #Condition statement

            // if / else

            // else if

            // switch

            // Ternary operator


            Console.ReadLine();
        }
    }
}
