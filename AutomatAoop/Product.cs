namespace AutomatAoop
{   //handles a static list of all different products from VendingMachine and prints out the ones containing whatever category the user chooses 
    public abstract class Product : Iproduct
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract string Category { get; set; }
        public abstract int Price { get; set; }

        public abstract string Effect { get; set; }


        // Presents a list of products depending on the category the user chooses in ProductCategoruSelection()
        public static void ProductSelection(string category)
        {
           
            Console.WriteLine(Menu.lines);
            Console.WriteLine(Menu.header);
            Wallet.walletInfo = $"Wallet: Krona: {Wallet.nrOfOneCrowns} Femma: {Wallet.nrOfFiveCrowns} Tia: {Wallet.nrOfTenCrowns} Total: {Wallet.totalWalletBalance}";
            VendingMachine.vendingMachine = $"Vendingmachine: Total value: {VendingMachine.CurrentVendingBalance}";
            List<Product> products = VendingMachine.productList.Where(p => p.Category == category).ToList();
            List<string> selectionOptions = products.Select(p => p.Name).ToList();
            selectionOptions.Add("Leave");
            MenuSelector product = new MenuSelector(Menu.header, Wallet.walletInfo, VendingMachine.vendingMachine, selectionOptions.ToArray(), 3, 1); 
            product.ResetCursorVisible();
            int topIndex = product.Navigate();
            if (topIndex >= products.Count)
            {
                Menu.ProductCategorySelection();
            }
            else
            {
                BuyProductMenu(products[topIndex]);
            }
        }

        //Handles the transaction part of the process
        public static void BuyProductMenu(Product product)
        {
            string header = "Welcome to the vending machince, use the arrow keys and enter key to navigate the app";
            string[] productMenu =
            {
                    "Yes",
                    "No"
                };
            YesNoSelector productTransaction = new YesNoSelector(header, Wallet.walletInfo, product.Name, product.Description, product.Category, product.Price, VendingMachine.vendingMachine, 10, 1, productMenu);
            int topIndex = productTransaction.Navigates();

            switch (topIndex)
            {
                case 0:
                    if (VendingMachine.CurrentVendingBalance < product.Price)
                    {
                        Console.WriteLine("Not enough coins in machine");
                        Console.ReadLine();
                        Menu.ProductCategorySelection();
                    }
                    else
                    {
                        product.BuyProduct();
                        Menu.ProductCategorySelection();
                    }
                    break;

                case 1:
                    Menu.ProductCategorySelection();

                    break;
            }
            return;
        }
        // Moneys is withdrawn and the product is used
        public void BuyProduct()
        {
            VendingMachine.CurrentVendingBalance -= Price;         
            Use();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        // Effect is a string that is decided depending on the category
        public void Use()
        {
            Console.WriteLine(Effect);
        }
    }
}