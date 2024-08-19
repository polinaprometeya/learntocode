namespace yahtzeeGame {

    class yahtzeeGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, yahtzee!");

            oneRandomDiceThrow();



        }

        static int oneRandomDiceThrow() {
            Random randomDiceThrow = new Random();
            var oneDiceResult = randomDiceThrow.Next(1,7);
            Console.WriteLine("Test: " + oneDiceResult);
            return oneDiceResult;
        }
    }
}
