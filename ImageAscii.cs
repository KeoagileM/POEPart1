using System;
using System.IO;

namespace POEPart1
{
    public class ImageAscii
    {
        public ImageAscii()
        {
            try
            {
                //Calling the method of printing the image
                printImage("ascii-art.txt", Console.ForegroundColor = ConsoleColor.Green);
            }
            catch (Exception ex)
            {
                //Message ro display if the picture is not found
                Console.WriteLine(ex.Message);
            }
            
            //Welcoming the user to the chatbot system
            Console.WriteLine("==================================================", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("=====  Welcome to the cybersecurity chatbot  =====", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("==================================================", Console.ForegroundColor = ConsoleColor.Green);
        }

        //Method to print the image
        public void printImage(string fileName, ConsoleColor color)
        {
            //StreamReader is used to read the file that is going to print the image
            StreamReader reader = new StreamReader(fileName);   

            Console.WriteLine(reader.ReadToEnd());
        }
    }
}