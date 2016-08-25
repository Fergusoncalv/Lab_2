using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        private static string Great;

        static void Main(string[] args)
        {
            Console.WriteLine("Hi. What is your Name?\n");
            string answername = Console.ReadLine();

            Console.WriteLine("Would you like to play a game?");
            Console.WriteLine("yes/no");
            bool stopProgram = false;
            if (!stopProgram)
            {
                Great = Console.ReadLine();
            }
            Console.WriteLine("Great");
            Console.WriteLine("Excellent! You are walking across a field and you encounter a fire-breathing dragon!\n");
            Console.WriteLine("What would you do?");
            Console.WriteLine("Face the Beast or Run Away\n");
            string answer = Console.ReadLine();
            if (answer == "Face the Beast")
            {
                Console.WriteLine("You approach the Dragon");
            }
            else if (answer == "Run Away")
            {
                Console.WriteLine("Coward");
            }

            string answerheads = "";
            do
            {
                Console.WriteLine("How many Heads does it have?");

                Console.WriteLine($"1,  2,  3");
                answerheads = Console.ReadLine();
            } while (int.Parse(answerheads) > 3);

            int head = int.Parse(answerheads);//We changed from string to int.
            switch (head)
            {
                case 1:
                    Console.WriteLine("You got it Easy");
                    break;
                case 2:
                    Console.WriteLine(" Now you're ready for battle!!");
                    break;
                case 3:
                    Console.WriteLine("Time to Kick some Butt");
                    break;


                default:
                    Console.WriteLine("Select another");
                    Console.ReadLine();
                    goto case 3;

                    break;

            }
            /* if (answerheads == "1") {
                 Console.WriteLine("You got it Easy"); }
             else if (answerheads == "2") {
                 Console.WriteLine(" Now you're ready for battle!!"); }
             else if (answerheads == "3"){
                 Console.WriteLine("Time to Kick some Butt");}*/
            // Console.ReadLine();
            Console.WriteLine("Choose your weapon");
            Console.WriteLine("Slingshot, Sword, Bow and Arrow");
            string answerweapon = Console.ReadLine();
            switch (answerweapon)
            {
                case "Slingshot":
                    Console.WriteLine("Hope he falls. Choose Rock Carefully");
                    break;
                case "Sword":
                    Console.WriteLine("Get Close and Ensure Sword is Sharp");
                    break;

                case "Bow and Arrow":
                    Console.WriteLine("Take good Aim");
                    break;
                default:
                    Console.WriteLine("Wrong Selection");
                    break;
            }
        }
    }

    /*   if (answerweapon == "Slingshot"){
           Console.WriteLine("Hope he falls. Choose Rock Carefully");}
       Console.ReadLine();
       if (answerweapon == "Sword")
       {
           Console.WriteLine("Get Close and Ensure Sword is Sharp");
       }
       Console.ReadLine();
       if (answerweapon == "Bow and Arrow")
       {
           Console.WriteLine("Take good Aim");
       }

*/
}








