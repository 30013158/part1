//Name:Rajveer Kaur
// topic:part 1-3 revision

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {//week 1 exercise

            Console.WriteLine("please enter your first name");
            string fName = Console.ReadLine();
            Console.WriteLine("please enter your last name");
            string lName = Console.ReadLine();
           
            string Name = fName + " " + lName;
            Console.WriteLine("Hello, " + Name);
            Console.WriteLine("enter your email address");
            string email = Console.ReadLine();
            Console.WriteLine("what is your gender(M/F):");
            string gender = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("************************Confirm your perrsonal details you entered**************************");
            Console.WriteLine($"\nName:{Name}\nEmail Address:{email}\nGender:{age}\nAge:{age}");
            Console.ReadLine();
            Console.WriteLine("#######################################################################################");
            Console.WriteLine("enter any number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter any decimal number:");
            double num2 =double.Parse(Console.ReadLine());
            double result;
            result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result} ");
            result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
            result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}");
            result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result}");
            Console.ReadLine();

            // conditional statement exercises
            Console.WriteLine("enter any number here");
            double digit1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            double digit2 = int.Parse(Console.ReadLine());
            string message;
            if (digit1 > digit2)
            { message = $"{ digit2} is smaller than {digit1}"; }
            else if (digit1 < digit2)
            { message = $"{digit1}is smaller than {digit2} "; }
            else
            { message = "these numbers are equal"; }
            Console.WriteLine(message);
            Console.ReadLine();
            Console.WriteLine("#############################");
            int myNum = 5;
            Console.WriteLine("Guess my number");
            int guess = int.Parse(Console.ReadLine());
            if (guess == myNum)
            { Console.WriteLine("genious man!you guessed it right"); }
            else if (guess > myNum)
            { Console.WriteLine("oops!your guess was too high"); }
            else
                    { Console.WriteLine("your guess was too low"); }
            Console.ReadLine();
            Console.WriteLine("#################################");
            Console.WriteLine("please enter your final score out of 100");
            double score = double.Parse(Console.ReadLine());

            if (score >= 90 && score < 100)
            { Console.WriteLine("you grade is A+"); }
           else if (score >=80 && score < 89)
            { Console.WriteLine("you grade is A"); }
           else if (score >=70 && score < 79)
            { Console.WriteLine("you grade is B+"); }
           else if (score >=60 && score < 69)
            { Console.WriteLine("you grade is B"); }
           else if (score >=50 && score < 59)
            { Console.WriteLine("you grade is C"); }
           else if (score >=40 && score < 49)
            { Console.WriteLine("you grade is D"); }
            else
            { Console.WriteLine("you grade is F"); }
            Console.ReadLine();













        }
    }
}
