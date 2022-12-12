namespace AutomatAoop
{
    public static class Menu
    {
        public static string header = "Welcome to the vending machince, use the arrow keys and enter key to navigate the app";
        public static string lines = "--------------------------------------------------------------------------------------";
       
        // Entrypoint/Main menu of program, contains instances of menyselector and coinbalance, used for navigation. 
        public static void ProductCategorySelection()
        {
            Console.WriteLine(lines);
            Console.WriteLine(header);
            CoinBalance cb = new CoinBalance();
            Wallet.walletInfo = $"Wallet: Onecrowns: {Wallet.nrOfOneCrowns} Fivers: {Wallet.nrOfFiveCrowns} Tenners: {Wallet.nrOfTenCrowns} Total: {Wallet.totalWalletBalance}kr";
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
            MenuSelector newMenu = new MenuSelector(header, Wallet.walletInfo, VendingMachine.vendingMachine, categoryMenu, 3, 1);
            
            newMenu.ResetCursorVisible();
            var topIndex = newMenu.Navigate();

            switch (topIndex)
            {
                case 0:
                    Product.ProductSelection("Bewerage");
                    break;

                case 1:
                    Product.ProductSelection("Food");
                    break;

                case 2:
                    Product.ProductSelection("Utility");
                    break;

                case 3:
                    Product.ProductSelection("Gum");
                    break;

                case 4:

                    cb.InsertCoin();
                    break;

                case 5:
                    LeaveWithChange();
                    Environment.Exit(0);
                    break;
            }
        }

        //Decides the highest possible coins and returns it to user before exiting program
        public static void LeaveWithChange()
        {
            int changeOne = 0;
            int changeFive = 0;
            int changeTen = 0;

            while (VendingMachine.CurrentVendingBalance > 0)
            {
                if (VendingMachine.CurrentVendingBalance >= 10)
                {
                    Wallet.nrOfTenCrowns++;
                    Wallet.totalWalletBalance += 10;
                    VendingMachine.CurrentVendingBalance -= 10;
                    changeTen++;
                }
                else if (VendingMachine.CurrentVendingBalance >= 5)
                {
                    Wallet.nrOfFiveCrowns++;
                    Wallet.totalWalletBalance += 5;
                    VendingMachine.CurrentVendingBalance -= 5;
                    changeFive++;
                }
                else
                {
                    Wallet.nrOfOneCrowns++;
                    VendingMachine.CurrentVendingBalance -= 1;
                    Wallet.totalWalletBalance += 1;
                    changeOne++;
                }
            }
            int changeTotal = changeOne + changeFive * 5 + changeTen * 10;
            Console.WriteLine($"Your change is {changeOne} crowns {changeFive} fivecrowns {changeTen} tenners total crowns: {changeTotal}");
            Console.WriteLine("Thank you for your patronage!");
            Console.ReadLine();
        }
    }
}