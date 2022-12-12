namespace AutomatAoop
{
    public class CoinBalance : IVendingInterface
    {
        // Handles transaction between wallet and vendingmachine balance, subtracts from one and adds to another
        public void InsertCoin()
        {
            string wallet = $"Wallet: Krona: {Wallet.nrOfOneCrowns} Femma: {Wallet.nrOfFiveCrowns} Tia: {Wallet.nrOfTenCrowns} Total value: {Wallet.totalWalletBalance} ";
            string vendingBalance = $"Vendingmachine: Total value: {VendingMachine.CurrentVendingBalance}";
            string header = "Welcome to the vending machince, use the arrow keys and enter key to navigate the app";
            Console.WriteLine(header);
            string[] insertCoinMenu =
            {
                    "one crown",
                    "one fiver",
                    "one tenner",
                    "Leave"
                };
            MenuSelector insertMenu = new MenuSelector(header, wallet, vendingBalance, insertCoinMenu, 3, 1);
            int topIndex = insertMenu.Navigate();

            switch (topIndex)

            {
                case 0:
                    if (Wallet.nrOfOneCrowns <= 0)
                    {
                        Console.WriteLine("you don't have the required coin");
                        Console.ReadLine();
                        InsertCoin();
                        break;
                    }
                    else
                    {
                        Wallet.nrOfOneCrowns -= 1;
                        VendingMachine.CurrentVendingBalance += 1;
                        Wallet.TotalBalance();
                        InsertCoin();
                    }
                    break;

                case 1:
                    if (Wallet.nrOfFiveCrowns <= 0)
                    {
                        Console.WriteLine("you don't have the required coin");
                        Console.ReadLine();
                        InsertCoin();
                        break;
                    }
                    else
                    {
                        Wallet.nrOfFiveCrowns -= 1;
                        VendingMachine.CurrentVendingBalance += 5;
                        Wallet.TotalBalance();
                        InsertCoin();
                    }
                    break;

                case 2:
                    if (Wallet.nrOfTenCrowns <= 0)
                    {
                        Console.WriteLine("you don't have the required coin");
                        Console.ReadLine();
                        InsertCoin();
                        break;
                    }
                    else
                    {
                        Wallet.nrOfTenCrowns -= 1;
                        VendingMachine.CurrentVendingBalance += 10;
                        Wallet.TotalBalance();
                        InsertCoin();
                    }
                    break;

                case 3:
                    Menu.ProductCategorySelection();
                    break;
            }
        }
    }
}