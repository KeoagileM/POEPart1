using System;

namespace POEPart1
{
    public class GreetingInteraction
    {
        public string name = "";
        public GreetingInteraction()
        {
            //Declaring the name
            
            //Callling the method
            userInteractions(name);
        }

        private void userInteractions(string name)
        {
            //Welvomes the user
            Console.WriteLine("ChatBot: --> Welcome to the Cybersecurity Awareness, Please enter your name ", Console.ForegroundColor = ConsoleColor.Blue);//Displays the message and makes the message blue
            Console.ForegroundColor = ConsoleColor.White;
            //Promts the user and the user enters the values
            Console.WriteLine("User: --> ");
            name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))//Makes sure that the user enters a name
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please make sure that you put your name, dont leave it empty");
                Console.ForegroundColor = ConsoleColor.White;
                name = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Greetings " + name + ", how can I help you today?");//Greets the user with the name
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("User: --> "); 
        }
    }
}