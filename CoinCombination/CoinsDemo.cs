namespace CoinCombination
{
    public class CoinsDemo
    {
        static void Main(string[] args)
        {
            double amountToTest = 53.28; // 0.53, 0.20, 0.27, 0.36, 0.22, 0.33, 2.56, 9.00, 7.95
            bool canMakeAmount = CanMakeAmount(amountToTest);
            Console.WriteLine($"Can make {amountToTest} using 0.04, 0.05 and 0.07 coins? {canMakeAmount}");
        }

        public static bool CanMakeAmount(double amount)
        {
            // First convert the amount to cents for easier calculations
            int totalCents = (int)(amount * 100);

            // Available coin denominations
            int[] coinDenominations = { 4, 5, 7 };

            // Array to track if an amount can be made
            bool[] isPossible = new bool[totalCents + 1];
            isPossible[0] = true;   // Assumption - Base case: 0 cents can always be made by not using any coins

            foreach (int coin in coinDenominations)
            {
                for (int cents = coin; cents <= totalCents; cents++)
                {
                    isPossible[cents] |= isPossible[cents - coin];
                }
            }

            return isPossible[totalCents];
        }
    }
}
