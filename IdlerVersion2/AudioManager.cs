using NAudio.Wave;

namespace Glitchquest
{
    public class AudioManager
    {
        private WaveOutEvent waveOutDevice;
        private AudioFileReader audioFileReader;
        private AudioFileReader audioFileReader1;
        private AudioFileReader audioFileReader2;
        private bool isFirstFilePlaying = false;
        public static string Walk1 = @"sounds\Walk1.flac";
        public static string Walk2 = @"sounds\Walk2.flac";
        public static string Soundtrack1 = @"sounds\QuietST.mp3";
        public static string Equip = @"sounds\Equip.mp3";
        public static string Potion = @"sounds\Potion.mp3";
        public static string Eat = @"sounds\Eat.mp3";
        public static string Sleep = @"sounds\Sleep.mp3";
        public void PlaySoundTrack(string soundTrack)
        {
            // Initialize WaveOutEvent
            waveOutDevice = new WaveOutEvent();
            audioFileReader = new AudioFileReader(soundTrack);

            // Initiate WaveOutDevice with AudioFileReader
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
            // Set up event handler for playback end
            waveOutDevice.PlaybackStopped += OnPlaybackStopped;
        }
        public void PlaySound(string soundFile)
        {
            // Initialize WaveOutEvent
            waveOutDevice = new WaveOutEvent();

            // Initialize AudioFileReaders
            audioFileReader = new AudioFileReader(soundFile);
            // Initiate WaveOutDevice with AudioFileReader1
            waveOutDevice.Init(audioFileReader);

            // Play the first sound
            waveOutDevice.Play();
        }
        public void PlaySequentialSounds(string soundFile1, string soundFile2)
        {
            // Initialize WaveOutEvent
            waveOutDevice = new WaveOutEvent();

            // Initialize AudioFileReaders
            audioFileReader1 = new AudioFileReader(soundFile1);
            audioFileReader2 = new AudioFileReader(soundFile2);

            // Hook up event handler for the first AudioFileReader
            waveOutDevice.PlaybackStopped += SequentialPlayBackStopped;

            // Initiate WaveOutDevice with AudioFileReader1
            waveOutDevice.Init(audioFileReader1);



            // Play the first sound
            waveOutDevice.Play();

            isFirstFilePlaying = true;
        }

        public void SequentialPlayBackStopped(object sender, StoppedEventArgs e)
        {
            if (isFirstFilePlaying)
            {
                isFirstFilePlaying = false;

                // Delay for 500 milliseconds (adjust as needed)
                Thread.Sleep(100);

                // Change the AudioFileReader to the second sound
                waveOutDevice.Stop();
                waveOutDevice.Init(audioFileReader2);
                waveOutDevice.Play();
            }
        }
        public void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            // Reset the position of the AudioFileReader to the beginning
            if (waveOutDevice != null && audioFileReader != null)
            {
                audioFileReader.Position = 0;
                waveOutDevice.Play();
            }
        }
        public void ActionSoundPlayer(int LastAction)
        {
            waveOutDevice = new WaveOutEvent();

            if (LastAction == 0)
            {
                PlaySound(Eat);
            }
            else if (LastAction == 1)
            {
                PlaySound(Potion);
            }
            else if (LastAction == 2)
            {
                PlaySound(Sleep);
            }
            else if (LastAction == 3)
            {
                PlaySound(Equip);
            }
            else
            {
                PlaySequentialSounds(Walk1, Walk2);
            }
        }
    }
}
