using System;
using System.IO;

namespace POEPart1
{
    public class ImageAscii
    {
        public ImageAscii()
        {
            //Calling the method of printing the image
            printImage("ascii-art.txt");
        }

        //Method to print the image
        public void printImage(string fileName)
        {
            //StreamReader is used to read the file that is going to print the image
            StreamReader reader = new StreamReader(fileName);   

            Console.WriteLine(reader.ReadToEnd());
        }
    }
}