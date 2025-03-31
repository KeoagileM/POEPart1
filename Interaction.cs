using System;
using System.Collections;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace POEPart1
{
    public class Interaction
    {
        
        public Interaction()
        {
            //ArrayList for the facts
            ArrayList keyResponses = new ArrayList();

            //ArrayList about ignoring the words
            ArrayList ignoreWords = new ArrayList();

            //Calling the getfacts method
            getFacts(keyResponses);

            string name = "";
            //Callling the method
            userInteractions(name, keyResponses);
        }

        //Method for getting the facts
        public void getFacts(ArrayList keyResponses)
        {
            keyResponses.Add("how are you=Im good thank you :)");
            keyResponses.Add("purpose=To teach you about cyber security best practices");
            keyResponses.Add("ask=You can ask me about how you can create Strong passwords, about Password's safety, What is Phishing and how to recognize a Phishing email, and what is a two factor authentication");
            keyResponses.Add("strong password=1)To create strong passwords you must: 1) Create long passwords, 2) Mix differents character types like using an uppercase, lowercase, numbers, and special characters");
            keyResponses.Add("password safety=Password safety is the practice of creating, managing, and protecting your password to prevent unauthorized access to your accounts and sensitive data or information");
            keyResponses.Add("phishing=Phishing is a cyberattack where scammers try to trick you into revealing sensitive information such as personal data, you can recognise them by emails that have a sense of emergency like, 'YOU HAVE WON A PRICE, CLICK HERE TO CLAIM'");
            keyResponses.Add("two-factor authentication=Two-factor authentication is an extra layer of security for your online accounts. it requires two tipes of verification which is *What you know(Password)* and *What you have(Phone, email, authenticator app)* ");
            keyResponses.Add("password=A password is a secret word or phrase that must be used to gain admission to a place.");
            keyResponses.Add("cybersecurity=Cybersecurity is the practice of protecting systems, networks, and programs from digital attacks");
            keyResponses.Add("cyberattack=An attempt to disrupt, damage, or gain unauthorized access to computer systems, network, or data");
            keyResponses.Add("antivirus=Antivirus is a software that scans a device or a network to detect security threats, alert you, and neutralize malicious code.");
            keyResponses.Add("ip=An IP address is a numeric label assigned to devices that use the internet to communicate, so you should be careful when sharing your IP address");
            //safebrowsing
            //malware
            //privacy
            //sql injection
            //data breach
            //Social engineering
        }

        //Method for user interactions
        private void userInteractions(string name, ArrayList keyResponses)
        {
            
            typingEffect("ChatBot: -->  Please enter your name ", Console.ForegroundColor = ConsoleColor.Blue);//Displays the message and makes the message blue
            Console.ForegroundColor = ConsoleColor.White;
            //Promts the user and the user enters the values
            Console.Write("User: --> ");
            name = Console.ReadLine();


            while (string.IsNullOrEmpty(name))//Makes sure that the user enters a name
            {

                typingEffect("Chatbot: --> Please make sure that you put your name, dont leave it empty", Console.ForegroundColor = ConsoleColor.DarkRed);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("User: --> ");
                name = Console.ReadLine();

            }

            String userFeeling;

            //Greets the user with the name
            typingEffect("Chatbot: --> Greetings " + name, Console.ForegroundColor = ConsoleColor.Green);

            do
            {
                //To check how the user feels 
                typingEffect("ChatBot: -->  Are you feeling good today ", Console.ForegroundColor = ConsoleColor.Blue);//Displays the message and makes the message blue
                Console.ForegroundColor = ConsoleColor.White;
                //Promts the user and the user enters the values
                Console.Write(name + ": --> ");
                userFeeling = Console.ReadLine().ToLower();


                //If the user enters yes
                if (userFeeling.Contains("yes"))
                {
                    typingEffect("Chatbot: --> That sounds great " + name, Console.ForegroundColor = ConsoleColor.Green);
                    break;
                }

                //If the user enters no
                else if (userFeeling.Contains("no"))
                {
                    typingEffect("Chatbot: --> Sorry to hear that, Remember tough times never last " + name, Console.ForegroundColor = ConsoleColor.Green);
                    break;
                }
                else
                {
                typingEffect("Chatbot: --> Please answer with a yes or a no " + name, Console.ForegroundColor = ConsoleColor.DarkRed);
                }
            }
            while (!userFeeling.Contains("yes") || !userFeeling.Contains("no")) ;
            
            

            //The responses of the user
            string response = "";

            //Boolean to find the correct answers
            Boolean found = false;

            //Do while loop to repeat until it is told to stop
            do
            {
                found = false;  // Reset found at the start
                typingEffect("Chatbot: --> How can I help you today?", Console.ForegroundColor =ConsoleColor.Blue);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(name + ": --> ");
                response = Console.ReadLine().ToLower();

                String message = "";

                foreach (string messages in keyResponses)
                {
                    string[] keyAndResponse = messages.Split('=');
                    string keyWord = keyAndResponse[0];

                    if (response.Contains(keyWord))
                    {
                        message += keyAndResponse[1] + "\n";
                        found = true;
                    }
                }

                if (found)
                {
                    typingEffect(message, Console.ForegroundColor = ConsoleColor.Green);
                }
                else if (response.Contains("exit"))
                {
                    typingEffect("Thank you for using our chatbot", Console.ForegroundColor = ConsoleColor.Green);
                    break;
                }
                else
                {
                    typingEffect("I could not understand that, I am only designed to answer about cybersecurity", Console.ForegroundColor = ConsoleColor.DarkRed);
                }
            } while (true);  // Ensure continuous interaction

        }
         
        //Method for typing effect
        private void typingEffect(string message, ConsoleColor color, int speed = 25)
        {

            ConsoleColor colorColor = color;
            foreach (char c in message)
            {
                Console.Write(c);

                System.Threading.Thread.Sleep(speed);//For the speed of the message
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}