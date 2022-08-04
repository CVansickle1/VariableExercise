using System;

namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myname = "Cody";
            int myage = 26;
            char lastinital = 'V';
            bool ismarried = false;
            double upload = 23.1;
            decimal download = 550.3m;

            string example = ismarried ? "am" : "am not";

            Console.WriteLine($"Hello my name is {myname} {lastinital}, I am {myage} I {example} married I will be in Febuary.");
            Console.WriteLine($"My Current Internet Speed is {upload} Up and {download} down");
            Console.WriteLine("What is your Upload Speed?");
            double yourUp;
            double yourDown;
            if (!double.TryParse(Console.ReadLine(), out yourUp)) Console.WriteLine("woah thats not what I expected try using regular number please");
            Console.WriteLine("What is your Download speed?");
            if (!double.TryParse(Console.ReadLine(), out yourDown)) Console.WriteLine("woah thats not what I expected try using regular number please");

            if (yourDown > 50)
            {
                Console.WriteLine("Wow thats Fast!");
            }
            else
            {
                Console.WriteLine("Not Bad!");
            }

        }
    }
}
