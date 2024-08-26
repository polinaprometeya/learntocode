using System;

namespace MusicDiceGame
{

    class MusicDiceGame
    {
        static void Main(string[] args)
        {
            getFiles();
            //Console.WriteLine("Your sum of two dice rolls : " + sumOfAllDiceRoll());
        }

        static void getFiles()
        {
            try
            {
                var minuets = musicFileMinuetNames();var trio =  musicFileTrioNames();
            for (int i=0; i<16; i++)
            {
                var fakeMusicMinuets = File.ReadAllText($"{musicFileFolder()}/{minuets[i]}");
                var fakeMusicTrio = File.ReadAllText($"{musicFileFolder()}/{trio[i]}");

                //Console.WriteLine("Test" + fakeMusicMinuets + fakeMusicTrio);
            }

            }
            catch
            {
                Console.WriteLine("Something went wrong");
            }

     
        }

        public static string musicFileFolder()
        {

            var currentDirectory = Directory.GetCurrentDirectory();
            var musicFileFolder = Path.Combine(currentDirectory, "Data");
            //Console.WriteLine(musicFilePath);
            return musicFileFolder;

        }

        static List<string> musicFileMinuetNames()
        {
          List<string> musicFilesMinuet = new List<string>(new string[] {});

            for (int i = 0; i<16; i++)
            {
                int rollNumber = i;
                int rollSum = sumOfAllDiceRoll();
                musicFilesMinuet.Add($"minuet{rollNumber}-{rollSum}.wav");
            }

            //Console.WriteLine("Test : " + musicFilesMinuet[0]);

            return musicFilesMinuet;
        }

        static List<string> musicFileTrioNames()
        {
            List<string> musicFileTrio = new List<string>(new string[] {});

            for (int i = 0; i < 16; i++)
            {
                int rollNumber = i;
                int rollSum = RandomDiceRoll();
                musicFileTrio.Add($"trio{rollNumber}-{rollSum}.wav");
            }

            //Console.WriteLine("Test : " + musicFileTrio[0]);
            return musicFileTrio;
        }



        public static int RandomDiceRoll()
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            return diceRoll;
        }

        public static int sumOfAllDiceRoll()
        {
            int diceRollOne = RandomDiceRoll();
            int diceRollTwo = RandomDiceRoll();

            //Console.WriteLine("Your dice rolled the following : " + diceRollOne + " and " + diceRollTwo);
            return diceRollOne + diceRollTwo;
        }

    }
}