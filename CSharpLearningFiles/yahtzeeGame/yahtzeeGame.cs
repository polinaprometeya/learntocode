namespace yahtzeeGame {

    class yahtzeeGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, yahtzee!");
            startRound();
        }

        static void startRound()
        {
            twrowWithDice(5);
            Console.WriteLine("How many dice do you want to save?");
            Console.ReadLine();
            int roundSavedThrows = Console.Read();
            if (roundSavedThrows != null && roundSavedThrows < 5)
            {
                nextRound(roundSavedThrows);
            }
        }

        static void nextRound(int roundSavedThrows)
        {
            List<int> userRoundThrowSaved = new List<int>(new int[] { });
            int saveOne;
            int saveTwo;
            int saveThree;
            int SaveFour;

            switch (roundSavedThrows)
            {
                case 2:
                     saveOne = 1;
                     saveTwo = 1;
                    break;

                case 3:
                    saveOne = 1;
                    saveTwo = 1;
                    saveThree = 1;
                    break;

                case 4:
                    saveOne = 1;
                    saveTwo = 1;
                    saveThree = 1;
                    SaveFour = 0;
                    break;

                default:
                    saveOne = 1;
                    break;
            }
            //Save all the chosen dice 3 throws Ask what dice result to store
        }

        static List<int> twrowWithDice(int numberOfDice)
        {
            List<int> userRoundThrow = new List<int>(new int[] { });
            for (int i=0; i < numberOfDice; i++)
            {
                var diceThrow = oneRandomDiceThrow();
                userRoundThrow.Add(diceThrow);
                Console.WriteLine($"Throwen dice {i + 1}: {diceThrow}");
            }
            return userRoundThrow;
        }

        static int oneRandomDiceThrow()
        {
            Random randomDiceThrow = new Random();
            var oneDiceResult = randomDiceThrow.Next(1, 7);
            return oneDiceResult;
        }

    }
}
