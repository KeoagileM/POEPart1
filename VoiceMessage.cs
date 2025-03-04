using System;
using System.Media;

namespace POEPart1
{
    public class VoiceMessage
    {
        public VoiceMessage()
        {
            //Calling the method of playing voice message
            playVoiceMessage("VoiceMessage.wav");
            Console.WriteLine("Welcome to the topics of Cyber Security");
        }

        //Method of playing the voice message
        public static void playVoiceMessage(string fileName)
        {
            SoundPlayer voiceMessage = new SoundPlayer();
            voiceMessage.SoundLocation = fileName;
            voiceMessage.Play();//Playing the audio
        }
    }
}