using System;
using System.Net.NetworkInformation;

namespace POEPart1
{
    public class Interaction
    {
        //Declaring the name
        public string name = "";

        //Information about cybersecurity and the responses of the chatbox
        public string[] facts = { //The response when the user asks how are you
                                  "Im good thank you :)",

                                  //The response for what the chatbox can do for you
                                  "To teach you about cybersecurity best practices, phishing scams, password managements and general online safety",

                                  //The response of asking about strong passwords
                                  "You can ask me about how you can create strong passwords, about password safety, What is phishing and how to recognize a phishing email, and what is a two-factor authentication",

                                  //This is the response for creating a Strong password
                                  "1)Create a long password" +
                                  "\n2) Mix differents character types like using an uppercase, lowercase, numbers, and special characters" +
                                  "\n3) Avoid common words and patterns like your name and birthday" +
                                  "\n4) Enable a two-factor authentication",

                                  //This is the response of safety of the password
                                  "Password safety is the practice of creating, managing, and protecting your password to prevent unauthorized access to your accounts and sensitive data or information",
                                  
                                  //Response asking about phishing
                                  "Phishing is a cyberattack where scammers try to trick you into revealing sensitive information such as passwords and personal data, you can recognise them by them:" +
                                  "\n1) Creating a sense of emergency in their mails like, 'YOU HAVE WON A PRICE, CLICK HERE TO CLAIM'" +
                                  "\n2) They do not address you by your name, the say 'Dear customer' instead of saying greetings " +
                                  "\n3) They create links, to avoid this, you should hover through links without clicking",

                                  //The two factor authentication response
                                  "Two-factor authentication is an extra layer of security for your online accounts. it requires two tipes of verification which is *What you know(Password)* and *What you have(Phone, email, authenticator app)* "};
        
        // This is the constructor
        public Interaction()
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


            Console.WriteLine("Greetings " + name );//Greets the user with the name
            //Do while loop to repeat until its told to stop
            string response = "";
            do
            {
            //Making the colour of the text blue
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" how can I help you today?" + name);//Greets the user with the name
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(name + ": --> ");

            //Asks the user to ask anything about cybersecurity
             response = Console.ReadLine();

                //This will tell the user about password safety
                if (response.Contains("how are you"))
                {

                    Console.WriteLine("ChatBot: --> " + facts[0], Console.ForegroundColor = ConsoleColor.Green);
                    
                }

                //When the user asks what is the purpose of the chatbox
                else if (response.Contains("purpose"))
                {
                    Console.WriteLine("ChatBot: --> " + facts[1], Console.ForegroundColor = ConsoleColor.Green);
                    
                
                }

                //When the user asks what he/she can ask in the chatbox
                else if (response.Contains("ask"))
                {
                    Console.WriteLine("ChatBot: --> " + facts[2], Console.ForegroundColor = ConsoleColor.Green);
                    
                }

                //When user asks about a strong password
                else if (response.Contains("strong password"))
                {
                    Console.WriteLine("ChatBot: --> " + facts[3], Console.ForegroundColor = ConsoleColor.Green);

                }

                //When user asks about password safety
                else if (response.Contains("password safety") || response.Contains("password"))
                {
                    Console.WriteLine("ChatBot: --> " + facts[4], Console.ForegroundColor = ConsoleColor.Green);

                }

                //When user asks about phishing
                else if (response.Contains("phishing"))
                {
                    Console.WriteLine("ChatBot: --> " + facts[5] + " " + name, Console.ForegroundColor = ConsoleColor.Green);

                }

                //When the user types something about 2 factor authentication
                else if (response.Contains("two factor authentication"))
                {
                    Console.WriteLine("ChatBot: --> " + facts[6], Console.ForegroundColor = ConsoleColor.Green);

                }
                //This will exit if the user types exit
                else if(response.Contains("exit")){
                    Console.WriteLine("ChatBot: --> Thank you for using our chatbox :)", Console.ForegroundColor = ConsoleColor.Green);
                    break;//Break is for exiting the program
                }

                //If the user enters anything else it will ask the user to enter the correct questions that are related to cyber security
                else
                {
                    Console.WriteLine("ChatBot: --> I didn't quite understand that. Could you rephrase? ", Console.ForegroundColor = ConsoleColor.DarkRed);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            } while (!response.Contains("How are you") || !response.Contains("purpose") || !response.Contains("ask") || !response.Contains("strong password") || !response.Contains("password") || response.Contains("password safety") || response.Contains("phishing") || response.Contains("two factor authentication"));
        }
    }
}