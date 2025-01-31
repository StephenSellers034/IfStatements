using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements;

class Program
{
    static void Main(string[] args)
    {
        int numberA;// assinged variables
        int numberB;

        Console.Write("Please enter the first number: ");
        string numberAInput = Console.ReadLine();//captures user input
        numberA = Convert.ToInt32(numberAInput);// formula used to convert string to int

        Console.Write("Please enter the second number: ");
        string numberBInput = Console.ReadLine();
        numberB = Convert.ToInt32(numberBInput);

        int answer = numberA * numberB;

        Console.Write("What is the value of " + numberA + " " + numberB + " multiplied");
        string answerInput = Console.ReadLine();
        int actualAnswer = Convert.ToInt32(answerInput);

        if (answer == actualAnswer)// will always be true or false
        {
            Console.WriteLine("Great Job!!! You got it correct.");
        }
        else// always will run as the backup in case the if is false
        {
            Console.WriteLine("Nice try but.... you got it wrong!!!");
        }

        Console.ReadLine();


    }
}

