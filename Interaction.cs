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

        //default responses for arraylist
        List<string> defaults = new List<string>();   

        //The favourite topic
        ArrayList favouriteTopic = new ArrayList();
        string feelingTopic = "";

        //The last topic
        string lastTopic = "";
        public Interaction()
        {
            //Creating an object to access the method from topic responces
            getFacts objGetFacts = new getFacts();
            //Calling the getfacts method
            objGetFacts.gettingFacts(topicResponses);
            objGetFacts.defaultResponses(defaults);
            string name = "";
            //Callling the method
            userInteractions(name);
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
                if ((response.Contains("more") || response.Contains("detail")) && !string.IsNullOrEmpty(lastTopic))
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
                        //Storing messages of the topic responses
                        var responses = messages.Value;
                        message += responses[random.Next(responses.Count)] + "\n";
                       
                        //Storing the keyword of the last topic
                        lastTopic = keyword;
                        found = true;

                        //For displaying the favourite topic
                        foreach(string item in favouriteTopic)
                        {
                            if (response.Contains(item))
                            {
                                message = "As a person interested in " + item + " knowing that " + responses[random.Next(responses.Count())];
                            }
                        }

                        //making sure that it knows what the user likes
                        if (response.Contains("interested") || response.Contains("love") || response.Contains("like"))
                        {
                            
                            message = "Amazing, I will make sure that i remember that you are interested in " + keyword;
                            favouriteTopic.Add(keyword);
                        }

                        //If the user is worried about something
                        if (response.Contains("worried") || response.Contains("worries") || response.Contains("worrying"))
                        {
                            feelingTopic = keyword;
                            message = "Its okay to be worried about " + feelingTopic + " just know that " + responses[random.Next(responses.Count)];                        
                        }

                        //when the user is curious about something
                        if (response.Contains("curious"))
                        {
                            feelingTopic = keyword;
                            message = "Being curious about " + feelingTopic + " is amazing!!! Knowing that " + responses[random.Next(responses.Count)] + " is going to help";
                        }

                        //When something frustrates the user
                        if (response.Contains("frustrated") || response.Contains("frustrating") || response.Contains("frustrates"))
                        {
                            feelingTopic = keyword;
                            message = "Being frustrated about " + feelingTopic + " is okay but knowing that " + responses[random.Next(responses.Count)] + " is going to help with frustration";
                        }

                        //When something angries the user
                        if (response.Contains("angry") || response.Contains("angries"))
                        {
                            feelingTopic = keyword;
                            message =  feelingTopic + " can make people angry, and knowing that " + responses[random.Next(responses.Count)] + " usually helps with people being angry";
                        }
                        break;

                    }

                }

                //If what ever you searched is found
                if (found)
                {
                    //Displaying the fact
                    typingEffect(message, Console.ForegroundColor = ConsoleColor.Green);
                }

                //If the user types exit
                else if (response.Contains("exit"))
                {
                    //When the user exits
                    typingEffect("Thank you for using our chatbot", Console.ForegroundColor = ConsoleColor.Green);
                    break;
                }

                //Anything else is wrong
                else
                {
                    //If the user does not enter anything related to cybersecurity
                    typingEffect(defaults[random.Next(defaults.Count)], Console.ForegroundColor = ConsoleColor.DarkRed);
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