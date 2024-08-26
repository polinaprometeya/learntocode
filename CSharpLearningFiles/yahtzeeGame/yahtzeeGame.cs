using System;

namespace yahtzeeGame {

    class yahtzeeGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, yahtzee!");
            playRound();
        }

        static void playRound()
        {
            List<int> userRoundThrowSaved = new List<int>(new int[] { });
            
            twrowWithDice(5);
            savedDice(userRoundThrowSaved);
            selectSection(userRoundThrowSaved);
        }

        static List<int> savedDice(List<int> userRoundThrowSaved)
        {
            string exit = "";
            while (exit != "n")
            {
                Console.WriteLine("Which throwen dice value would you want to save ?");
                int userAnswer = Console.Read();
                if (0 < userAnswer && userAnswer < 7) { userRoundThrowSaved.Add(userAnswer); }


                Console.WriteLine("Do you want to save more dice y/n?");
                exit = Console.ReadLine();
            }
            return userRoundThrowSaved;
        }

        static int savedNumbersSum(List<int> userRoundThrowSaved)
        {
            int roundSum = 0;
            userRoundThrowSaved.ForEach(x => roundSum += x);
            return roundSum;
        }

        static void selectedSection(List<int> userRoundThrowSaved)
        {
            int roundSum = savedNumbersSum(userRoundThrowSaved);
            Console.WriteLine("-----------------------------\n" +
                "Do you want to bet Upper section or Lower Section? ? Write 0 for Upper and 1 for Lower ");

            int userSectionAnswer = Console.Read();
            if (userSectionAnswer == 0)
            { upperSection(roundSum); }
            else
            { lowerSection(userRoundThrowSaved, roundSum); }
        }

        static void upperSection(int roundSum)
        {
            Console.WriteLine("-----------------------------\n" +
                "1.Five Aces?\n" +
                "2.Five Twos?\n" +
                "3.Five Threes?\n" +
                "4.Five Fours?\n" +
                "5.Five Fives?\n" +
                "6.Five Sixes?\n" +
                "-----------------------------\n");
            int upperSectionAnswer = Console.Read();

            switch (upperSectionAnswer)
            {

                case 1:
                    if (0 < roundSum && roundSum < 6)
                    { savedNumbersSum(roundSum); }
                    break;

                case 2:
                    if (5 < roundSum && roundSum < 11)
                    { savedNumbersSum(roundSum);}
                    break;

                case 3:
                    if (10 < roundSum && roundSum < 16)
                    { savedNumbersSum(roundSum);}
                    break;

                case 4:
                    if (15 < roundSum && roundSum < 21)
                    { savedNumbersSum(roundSum);}
                    break;

                case 5:
                    if (20 < roundSum && roundSum < 26)
                    { savedNumbersSum(roundSum);}
                    break;

                case 6:
                    if (25 < roundSum && roundSum <= 30)
                    { savedNumbersSum(roundSum);}
                    break;

                default:
                    Console.WriteLine("Something went wrong ");
                    break;
            }
            //Save all the chosen dice 3 throws Ask what dice result to store
        }

        static void lowerSection(List<int> userRoundThrowSaved, int roundSum)
        {
            
            int occurenceOfOne = userRoundThrowSaved.Count(i => i == 1);
            int occurenceOfTwo = userRoundThrowSaved.Count(i => i == 2);
            int occurenceOfThree = userRoundThrowSaved.Count(i => i == 3);
            int occurenceOfFour = userRoundThrowSaved.Count(i => i == 4);
            int occurenceOfFive = userRoundThrowSaved.Count(i => i == 5);
            int occurenceOfSix = userRoundThrowSaved.Count(i => i == 6);

            Console.WriteLine("-----------------------------\n" +
            "7.Three of a kind?\n" +
            "8.Four of a kind?\n" +
            "9.Full house?\n" +
            "10 Little Straight?\n" +
            "11.Large Straight?\n" +
            "12.Five of a kind?\n" +
            "13.Chance?\n"
            );

            int upperSectionAnswer = Console.Read();

            switch (upperSectionAnswer)
            {
                case 7:
                    if (occurenceOfOne == 3 || occurenceOfTwo == 3 || occurenceOfThree == 3 || occurenceOfFour == 3 ||  occurenceOfFive == 3 || occurenceOfSix == 3)
                    { savedNumbersSum(roundSum);}
                    break;

                case 8:
                    if (occurenceOfOne == 4 || occurenceOfTwo == 4 || occurenceOfThree == 4 || occurenceOfFour == 4 || occurenceOfFive == 4 || occurenceOfSix == 4)
                    { savedNumbersSum(roundSum);}
                    break;

                case 9:
                    if (occurenceOfOne == 3 || occurenceOfTwo == 3 || occurenceOfThree == 3 || occurenceOfFour == 3 || occurenceOfFive == 3 || occurenceOfSix == 3 && occurenceOfOne == 2 || occurenceOfTwo == 2 || occurenceOfThree == 2 || occurenceOfFour == 2 || occurenceOfFive == 2 )
                    { savedNumbersSum(25);}
                    break;

                case 10:
                   var littleStraight = string.Join("", userRoundThrowSaved.ToArray());
                    if (littleStraight == "6543" || littleStraight == "5432" || littleStraight == "4321")
                    { savedNumbersSum(30);}
                    break;

                case 11:
                    string bigStraightUser = string.Join("", userRoundThrowSaved.ToArray());

                    if (bigStraightUser == "65432" || bigStraightUser == "54321")
                    { savedNumbersSum(40);}
                    break;

                case 12:
                    if (occurenceOfOne == 5 || occurenceOfTwo == 5 || occurenceOfThree == 5 || occurenceOfFour == 5 || occurenceOfFive == 5 || occurenceOfSix == 5)
                    { savedNumbersSum(50);}
                    break;

                case 13:
                    savedNumbersSum(roundSum);
                    break;

                default:
                    Console.WriteLine("Something went wrong");
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
