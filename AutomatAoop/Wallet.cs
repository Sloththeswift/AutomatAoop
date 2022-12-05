namespace AutomatAoop
{
    public static class Wallet
    {
        public static int nrOfOneCrowns { get; set; }
        public static int nrOfFiveCrowns { get; set; }
        public static int nrOfTenCrowns { get; set; }
        public static int totalWalletBalance { get; set; }

        public static volatile string wallet = $"Wallet: Krona: {nrOfOneCrowns} Femma: {nrOfFiveCrowns} Tia: {nrOfTenCrowns} Total value: {totalWalletBalance} ";

        public static void TotalBalance()
        {
            totalWalletBalance = nrOfOneCrowns + nrOfFiveCrowns * 5 + nrOfTenCrowns * 10;
        }
    }
}