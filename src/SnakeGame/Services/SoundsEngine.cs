using System.IO;
using System.Media;

namespace SnakeGame.Services
{
    public static class SoundsEngine
    {
        public static void PlayIncreaseScoreSound()
        {
            string directory = Directory.GetCurrentDirectory();
            string soundPath = directory + "\\Sounds\\game-notification.wav";
            if (File.Exists(soundPath))
            {
                SoundPlayer simpleSound = new SoundPlayer(soundPath);
                simpleSound.Play();
            }
        }

        public static void PlayGameOverSound()
        {
            string directory = Directory.GetCurrentDirectory();
            string soundPath = directory + "\\Sounds\\game-over.wav";
            if (File.Exists(soundPath))
            {
                SoundPlayer simpleSound = new SoundPlayer(soundPath);
                simpleSound.Play();
            }
        }
    }
}
