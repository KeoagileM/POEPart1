using System;
using System.Net.NetworkInformation;

namespace POEPart1
{
    public class GreetingInteraction
    {
        //Declaring the name
        public string name = "";
        public string[] facts = { "Passwords are easily hacked because most humans follow similar patterns",
                               "Phishing is the most common form of cyber crime, with an estimated 3.4 billion spam emails sent every day.",
                               "Verify Links before Clicking" };
        public GreetingInteraction()
        {
            
            
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

            //Asks the user to ask anything about cybersecurity
            string response = Console.ReadLine();
            do
            {
                if (response.Contains("password safety"))
                {

                    Console.WriteLine("ChatBot: --> " + facts[0], Console.ForegroundColor = ConsoleColor.Green);
                    break;
                }
                else if (response.Contains("phishing"))
                {
                    Console.WriteLine("ChatBot: --> " + facts[1], Console.ForegroundColor = ConsoleColor.Green);
                    break;
                }
                else if (response.Contains("safe browsing"))
                {
                    Console.WriteLine("ChatBot: --> " + facts[2], Console.ForegroundColor = ConsoleColor.Green);
                    break;
                }
                else
                {
                    Console.WriteLine("ChatBot: --> Please ask questions about cybersecurity", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("User: --> ");
                    response = Console.ReadLine();  
                }
            } while (!response.Contains("password safety") || !response.Contains("phishing") || !response.Contains("safe browsing"));
        }
    }
}