namespace AutomatAoop
{
    public class CoinBalance : IVendingInterface
    {
        public void InsertCoin()
        {
            string wallet = $"Wallet: Krona: {Wallet.nrOfOneCrowns} Femma: {Wallet.nrOfFiveCrowns} Tia: {Wallet.nrOfTenCrowns} Total value: {Wallet.totalWalletBalance} ";
            string vendingBalance = $"Vendingmachine: Total value: {VendingMachine.CurrentVendingBalance}";

            string[] insertCoinMenu =
            {
                    "one crown",
                    "one fiver",
                    "one tenner",
                    "Leave"
                };
            MenuSelector insertMenu = new MenuSelector(Menu.header, wallet, vendingBalance, insertCoinMenu);
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