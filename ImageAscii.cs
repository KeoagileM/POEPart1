using System;
using System.Drawing;
using System.IO;

namespace POEPart1
{
    public class ImageAscii
    {
        public ImageAscii()
        {

            

                //get app full path
                string paths = AppDomain.CurrentDomain.BaseDirectory;

                //then replace the bin\\bebug\\
                string new_path = paths.Replace("bin\\Debug\\", "");

                //then combine the logo and the image
                string full_path = Path.Combine(new_path, "CyberSecurityImage2.jpg");
                Console.WriteLine(full_path);
                //then start working on the ascii
                Bitmap Logo = new Bitmap(full_path);
                Logo = new Bitmap(Logo, new Size(120, 70));

                for (int height = 0; height < Logo.Height; height++)
                {
                    //for width
                    for (int width = 0; width < Logo.Width; width++)
                    {
                        Color pixelColor = Logo.GetPixel(width, height);
                        int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        char asciiChar = gray > 200 ? '.' : gray > 150 ? '*' : gray > 100 ? 'o' : gray > 50 ? '#' : '@';
                        Console.Write(asciiChar);

                    }
                    Console.WriteLine();

                }



            

            //Welcoming the user to the chatbot system
            Console.WriteLine("==================================================", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("=====  Welcome to the cybersecurity chatbot  =====", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("==================================================", Console.ForegroundColor = ConsoleColor.Green);
        }

    }
}