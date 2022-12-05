namespace AutomatAoop
{
    public static class Menu
    {
        public static void WalletInitializer()
        {
            Wallet.nrOfOneCrowns += 10;
            Wallet.nrOfFiveCrowns += 10;
            Wallet.nrOfTenCrowns += 10;
            Wallet.totalWalletBalance += 160;
        }

        public static string header = "Welcome to the vending machince, use the arrow keys and enter key to navigate the app";

        public static void ProductCategorySelection()
        {
            CoinBalance cb = new CoinBalance();
            Wallet.wallet = $"Wallet: Onecrowns: {Wallet.nrOfOneCrowns} Fivers: {Wallet.nrOfFiveCrowns} Tenners: {Wallet.nrOfTenCrowns} Total: {Wallet.totalWalletBalance}kr";
            VendingMachine.vendingMachine = $"Vendingmachine: Total value: {VendingMachine.CurrentVendingBalance}";

            string[] categoryMenu =
            {
                    "Bewerages",
                    "Food",
                    "Utilities",
                    "Gum",
                    "Insert coins",
                    "Leave"
                };
            MenuSelector newMenu = new MenuSelector(header, Wallet.wallet, VendingMachine.vendingMachine, categoryMenu);
            int topIndex = newMenu.Navigate();

            switch (topIndex)
            {
                case 0:
                    Products.BewerageSelection();
                    break;

                case 1:
                    Products.FoodSelection();
                    break;

                case 2:
                    Products.UtilitySelection();
                    break;

                case 3:
                    Products.GumSelection();
                    break;

                case 4:
                    cb.InsertCoin();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}