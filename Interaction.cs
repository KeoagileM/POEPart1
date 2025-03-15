using System;
using System.Collections;
using System.Net.NetworkInformation;

namespace POEPart1
{
    public class Interaction
    {
        
        public Interaction()
        {
            //ArrayList for the facts
            ArrayList facts = new ArrayList();

            //ArrayList about ignoring the words
            ArrayList ignoreWords = new ArrayList();

            //Calling the getfacts method
            getFacts(facts);

            //Calling the ignore letters method
            ignoreLetters(ignoreWords);

            string name = "";
            //Callling the method
            userInteractions(name, facts, ignoreWords);
        }

        //Method for getting the facts
        public void getFacts(ArrayList facts)
        {
            facts.Add("Im good thank you :)");
            facts.Add("To teach you about cyber security best practices");
            facts.Add("You can ask me about how you can create Strong passwords, about Password's safety, What is Phishing and how to recognize a Phishing email, and what is a two factor authentication");
            facts.Add("1)To create strong passwords you must: 1) Create long passwords, 2) Mix differents character types like using an uppercase, lowercase, numbers, and special characters\"");
            facts.Add("password safety is the practice of creating, managing, and protecting your password to prevent unauthorized access to your accounts and sensitive data or information");
            facts.Add("phishing is a cyberattack where scammers try to trick you into revealing sensitive information such as personal data, you can recognise them by emails that have a sense of emergency like, 'YOU HAVE WON A PRICE, CLICK HERE TO CLAIM'");
            facts.Add("two-factor authentication is an extra layer of security for your online accounts. it requires two tipes of verification which is *What you know(Password)* and *What you have(Phone, email, authenticator app)* ");
            facts.Add("A password is a secret word or phrase that must be used to gain admission to a place.");
            facts.Add("cybersecurity is the practice of protecting systems, networks, and programs from digital attacks");
            
        }

        //Methid for ignoring unnecesssary words
        private void ignoreLetters(ArrayList ignoreLetters)
        {
            ignoreLetters.Add("what");
            ignoreLetters.Add("is");
            ignoreLetters.Add("tell");
            ignoreLetters.Add("me");
            ignoreLetters.Add("about");
        }
        
        private void userInteractions(string name, ArrayList facts, ArrayList ignoreWords)
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
            //Boolean to find the correct answers
            Boolean found = false;
            do
            {
            //Making the colour of the text blue
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" how can I help you today?" + name);//Greets the user with the name
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(name + ": --> ");

            //Asks the user to ask anything about cybersecurity
             response = Console.ReadLine();

                //For making the responses lowercase
                response = response.ToLower();

                //Using the split to seperate the sentaces
                string[] storeWords = response.Split(' ');
                ArrayList filter = new ArrayList();

                //For loop to store the users sentences
                for(int i = 0; i < storeWords.Length; i++)
                {
                    if (!ignoreWords.Contains(storeWords[i])) ;
                    filter.Add(storeWords[i]);
                }

                
                String message = "";

                //Disp;aying the answers
                for(int i = 0; i < filter.Count; i++)
                {
                    //Nested for loop to display
                    for (int j = 0; j < facts.Count; j++)
                    {
                        if (facts[j].ToString().Contains(filter[i].ToString()))
                        {
                            found = true;
                            message += facts[j] + "\n"; 
                        }
                    }
                }

                //If statement to display everything
                if (found)
                {
                    Console.WriteLine(message);
                }else if (response.Contains("exit"))
                {
                    Console.WriteLine("Thank you for using our chatbox", Console.ForegroundColor = ConsoleColor.Green);
                    break;
                }
                else
                {
                    Console.WriteLine("Please write something related to cybersecurity");
                }
            } while (!response.Contains("exit") || found || !found);
        }
    }
}