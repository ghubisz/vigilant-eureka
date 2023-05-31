using System;

namespace Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
        BeginGame:
            Console.WriteLine("Welcome to the Magic 8 Ball Game!");

            ConsoleColor PreGameColor = Console.ForegroundColor;
        AskQuestion:
            Console.Write("\nAsk me a question!");
            string response = Console.ReadLine();
            RandomizeConsoleOutputColor();
            GetResponse();
            ResetConsoleColor(PreGameColor);

            Console.WriteLine("---");
            goto AskQuestion;

        }

        static void ResetConsoleColor(ConsoleColor PreGame)
        {
            Console.ForegroundColor = PreGame;
        }

        static void GetResponse()
        {
            int result;
            Random rnd = new Random();
            result = rnd.Next(1,21);
            switch(result)
            {
                case1:
                    Console.WriteLine("As I see it, Yes!");
                    break;
                case2:
                    Console.WriteLine("Ask me again later!");
                    break;
                case3:
                    Console.WriteLine("Better not ask me now!");
                    break;
                case4:
                    Console.WriteLine("Cannot predict now");
                    break;
                case5:
                    Console.WriteLine("Concentrate and ask again!");
                    break;
                case6:
                    Console.WriteLine("Don't count on it!");
                    break;
                case7:
                    Console.WriteLine("It is certain!");
                    break;
                case8:
                    Console.WriteLine("It is decidely so!");
                    break;
                case9:
                    Console.WriteLine("My reply is no!");
                    break;
                case10:
                    Console.WriteLine("My sources say no!");
                    break;
                case11:
                    Console.WriteLine("Outlook not so good!");
                    break;
                case12:
                    Console.WriteLine("Outlook good!");
                    break;
                case13:
                    Console.WriteLine("Reply hazy, try again.");
                    break;
                case14:
                    Console.WriteLine("Signs point to YES!");
                    break;
                case15:
                    Console.WriteLine("Very doubtful!");
                    break;
                case16:
                    Console.WriteLine("Without a doubt!");
                    break;
                case17:
                    Console.WriteLine("Yes!");
                    break;
                case18:
                    Console.WriteLine("Yes - definitely");
                    break;
                case19:
                    Console.WriteLine("You may rely on it!");
                    break;
                case20:
                    Console.WriteLine("Not certain");
                    break;
                
            }
        }

        static void RandomizeConsoleOutputColor()
        {
            int result;
            Random rnd = new Random();
            result = rnd.Next(1,5);
            switch (result)
            {
                case1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case5:
                    Console.ForegroundColor = ConsoleColor.Pink;
                    break;

                default:
            }
        }
    }
}
