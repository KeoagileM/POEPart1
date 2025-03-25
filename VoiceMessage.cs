using System;
using System.Media;

namespace POEPart1
{
    public class VoiceMessage
    {
        public VoiceMessage()
        {
            try
            {
                //Calling the method of playing voice message
                playVoiceMessage("WelcomeMessage.wav");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
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