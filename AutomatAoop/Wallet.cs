namespace AutomatAoop
{
    public static class Wallet
    {

        // A static wallet class with 4 diffrent integers that represent the value of coins or the total sum of all coins. 
        public static int nrOfOneCrowns { get; set; } = 10;
        public static int nrOfFiveCrowns { get; set; } = 10;
        public static int nrOfTenCrowns { get; set; } = 10;
        public static int totalWalletBalance { get; set; } = 160;

        // interpolated volatile string used as a dynamic footer to display the current amount left in wallet 

        public static volatile string walletInfo = $"Wallet: Krona: {nrOfOneCrowns} Femma: {nrOfFiveCrowns} Tia: {nrOfTenCrowns} Total value: {totalWalletBalance} ";

        // Calculates the value of coins in wallet
        public static void TotalBalance()
        {
            totalWalletBalance = nrOfOneCrowns + nrOfFiveCrowns * 5 + nrOfTenCrowns * 10;
        }
    }
}