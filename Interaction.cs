using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace POEPart1
{
    public class Interaction
    {
        //Dictionary for the topic and the responses
        Dictionary<string, List<string>> topicResponses = new Dictionary<string, List<string>>();

        //The favourite topic
        string favouriteTopic = "";
        string feelingTopic = "";

        //The last topic
        string lastTopic = "";
        public Interaction()
        {
            //Calling the getfacts method
            getFacts();

            string name = "";
            //Callling the method
            userInteractions(name);
        }

        //Method for getting the facts
        public void getFacts()
        {
            
            topicResponses["how are you"] = new List<string>
            {
                "Im good thank you"
            };
            topicResponses["purpose"] = new List<string>
            {
                "To teach you about cybersecurity"
            };
            topicResponses["ask"] = new List<string>
            {
                "You can ask me about how you can create Strong passwords, what is a password, about Password's safety, What is Phishing and how to recognize a Phishing email, two factor authentication,cybersecurity, cyberattacks, antiviruses, and alot more."
            };
            topicResponses["strong passwords"] = new List<string>
            {
                "A strong password is difficult for others (including hackers) to figure out because it doesn’t use obvious information like names or birthdays.",
                "It uses a combination of uppercase and lowercase letters, numbers, and symbols to make it more secure.",
                "A strong password helps keep your accounts and personal information safe from cyberattacks."
            };
            topicResponses["password safety"] = new List<string>
            {
                " Password safety means using and managing passwords in a way that keeps your online accounts secure from unauthorized access.",
                "Password involves taking steps (like not sharing passwords or using weak ones) to prevent hackers from stealing your personal, financial, or sensitive information.",
                "Password safety means following good habits—like changing passwords regularly, using different passwords for different accounts, and storing them securely (e.g., using a password manager)."
            }; 
            topicResponses["phishing"] = new List<string>
            {
                "A cyber trick where someone pretends to be a trusted company to steal your information.",
                "Fake emails, messages, or websites that try to make you click on harmful links.",
                "A common scam to get passwords, bank info, or personal data."
            };
            topicResponses["two-factor authentication"] = new List<string>
            {
                "It adds a second step to the login process, even when someone knows the password, they cant login without the second factor",
                "You need to provide two things: something you know (like a password) and something you have (like a code sent to your phone or email).",
                "2FA helps protect your accounts from cybercriminals by making it harder for them to log in, even if they steal your password."
            };
            topicResponses["password"] = new List<string>
            {
                "A secret code used to protect your account or device.",
                "Your digital key that keeps your information safe from others.",
                "A combination of letters, numbers, and symbols used to log in securely."
            };
            topicResponses["cybersecurity"] = new List<string>
            {
                "The protection of computers and networks from hackers and threats.",
                "A set of tools and practices to keep your data safe online.",
                "The digital version of locking your doors and windows to keep out intruders."
            };
            topicResponses["cyberattack"] = new List<string>
            {
                "A harmful action targeting your computer, network, or data.",
                "When a hacker tries to break into your system or account.",
                "A way to steal, damage, or destroy information using technology."
            };
            topicResponses["antivirus"] = new List<string>
            {
                "Antivirus is a program that protects your computer or device from harmful software like viruses, worms, and spyware.",
                "It scans your files and system to find and remove threats that can damage your device or steal your information.",
                "Antivirus acts like a bodyguard for your computer—it watches for danger, warns you, and stops harmful programs from causing harm."
            };
            topicResponses["ip"] = new List<string>
            {
                "A unique number that identifies your device on the internet.",
                "Like a home address but for your computer or phone.",
                "Used to find and connect devices on a network."
            };
            topicResponses["safe browsing"] = new List<string>
            {
                "Using the internet in a way that avoids danger and scams.",
                "Not clicking on suspicious links or pop-ups.",
                "Visiting trusted and secure websites only."
            };
            topicResponses["privacy"] = new List<string>
            {
                "The right to keep your personal data safe and hidden.",
                "Controlling who sees your information online.",
                "Protecting your identity, conversations, and online activity."
            };
            topicResponses["malware"] = new List<string>
            {
                "Software made to harm your computer or steal your information.",
                "Includes viruses, worms, spyware, and ransomware.",
                "A hidden digital threat that can slow down or damage your device."
            };
            topicResponses["social engineering"] = new List<string>
            {
                "Tricking people into giving up private information.",
                "A hacker pretending to be someone you trust.",
                "Using human interaction (not code) to break into systems."
            };
        }
        //Method for user interactions
        private void userInteractions(string name)
        {
            
            typingEffect("ChatBot: -->  Please enter your name ", Console.ForegroundColor = ConsoleColor.Blue);//Displays the message and makes the message blue
            Console.ForegroundColor = ConsoleColor.White;
            //Promts the user and the user enters the values
            Console.Write("User: --> ");
            name = Console.ReadLine();

            while (string.IsNullOrEmpty(name) || !Regex.IsMatch(name, @"^[A-Za-z]+$"))//Makes sure that the user enters a name
            {

                typingEffect("Chatbot: --> Please make sure that you put your name, dont leave it empty and must contain only letters, not numbers or special characters", Console.ForegroundColor = ConsoleColor.DarkRed);
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
                typingEffect("ChatBot: -->  Are you feeling good today? ", Console.ForegroundColor = ConsoleColor.Blue);//Displays the message and makes the message blue
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
                    //When the user enters the answer that is yes or no
                typingEffect("Chatbot: --> Please answer with a yes or a no " + name, Console.ForegroundColor = ConsoleColor.DarkRed);
                }
            }
            while (!userFeeling.Contains("yes") || !userFeeling.Contains("no")) ;
            
            

            //The responses of the user
            string response = "";

            //Boolean to find the correct answers
            Boolean found = false;

            //Randomizer class or instance
            Random random = new Random();

            //Do while loop to repeat until it is told to stop
            do
            {
                found = false;  // Reset found as false at the start
                typingEffect("Chatbot: --> How can I help you today?", Console.ForegroundColor =ConsoleColor.Blue);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(name + ": --> ");
                response = Console.ReadLine().ToLower();

                //Message for the responses
                string message = "";

                // Check if user wants more information about the last topic
                if ((response.Contains("more") || response.Contains("details")) && !string.IsNullOrEmpty(lastTopic))
                {
                    var responses = topicResponses[lastTopic];
                    message = responses[random.Next(responses.Count)] + "\n";
                    typingEffect(message, Console.ForegroundColor = ConsoleColor.Green);
                    continue;
                }


                foreach (var messages in topicResponses)
                {
                    string keyword = messages.Key;

                    if (response.Contains(keyword))
                    {
                        var responses = messages.Value;
                        message += responses[random.Next(responses.Count)] + "\n";
                       
                        lastTopic = keyword;
                        found = true;

                        //making sure that it knows what the user likes
                        if (response.Contains("interested") || response.Contains("love") || response.Contains("like"))
                        {
                            favouriteTopic = keyword;
                            message = "Amazing, I will make sure that i remember that you are interested in " + favouriteTopic;
                        }

                        if (response.Contains("worried"))
                        {
                            feelingTopic = keyword;
                            message = "Its okay to be worried about " + feelingTopic + " just know that it involes " + responses[random.Next(responses.Count)];                        
                        }

                        if (response.Contains("curious"))
                        {
                            feelingTopic = keyword;
                            message = "Its okay to be curiouse about " + feelingTopic + " just know that it involes " + responses[random.Next(responses.Count)];
                        }

                        if (response.Contains("frustrated"))
                        {
                            feelingTopic = keyword;
                            message = "Its okay to be frustrated about " + feelingTopic + " just know that it involes " + responses[random.Next(responses.Count)];
                        }

                    }

                }

                if (found)
                {
                    //Displaying the fact
                    typingEffect(message, Console.ForegroundColor = ConsoleColor.Green);
                }
                else if (response.Contains("exit"))
                {
                    //When the user exits
                    typingEffect("Thank you for using our chatbot", Console.ForegroundColor = ConsoleColor.Green);
                    break;
                }else if (!string.IsNullOrEmpty(favouriteTopic))
                {
                    typingEffect("As someone interested in " + favouriteTopic + " remember that it involves " + topicResponses[favouriteTopic][random.Next(topicResponses[favouriteTopic].Count)], Console.ForegroundColor = ConsoleColor.Green);

                }
                else
                {
                    //If the user does not enter anything related to cybersecurity
                    typingEffect("I could not understand that, I am only designed to answer about cybersecurity", Console.ForegroundColor = ConsoleColor.DarkRed);
                }
            } while (true);  

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