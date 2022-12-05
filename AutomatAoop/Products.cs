namespace AutomatAoop
{
    public class Products
    {
        public abstract class Product
        {
            public abstract string Name { get; set; }
            public abstract string Description { get; set; }
            public abstract string Category { get; set; }
            public abstract int Price { get; set; }
        }

        public class Bewerage : Product
        {
            public override string Name { get; set; }
            public override string Description { get; set; }
            public override string Category { get; set; }
            public override int Price { get; set; }

            public Bewerage(string Name, string Description, string Category, int Price)
            {
                this.Name = Name;
                this.Description = Description;
                this.Category = Category;
                this.Price = Price;
            }
        }

        public class Food : Product
        {
            public Food(string Name, string Description, string Category, int Price)
            {
                this.Name = Name;
                this.Description = Description;
                this.Category = Category;
                this.Price = Price;
            }

            public override string Name { get; set; }
            public override string Description { get; set; }
            public override string Category { get; set; }
            public override int Price { get; set; }
        }

        public class Utility : Product
        {
            public Utility(string Name, string Description, string Category, int Price)
            {
                this.Name = Name;
                this.Description = Description;
                this.Category = Category;
                this.Price = Price;
            }

            public override string Name { get; set; }
            public override string Description { get; set; }
            public override string Category { get; set; }
            public override int Price { get; set; }
        }

        public class Gum : Product
        {
            public Gum(string Name, string Description, string Category, int Price)
            {
                this.Name = Name;
                this.Description = Description;
                this.Category = Category;
                this.Price = Price;
            }

            public override string Name { get; set; }
            public override string Description { get; set; }
            public override string Category { get; set; }
            public override int Price { get; set; }
        }

        public static void BewerageSelection()
        {
            Wallet.wallet = $"Wallet: Krona: {Wallet.nrOfOneCrowns} Femma: {Wallet.nrOfFiveCrowns} Tia: {Wallet.nrOfTenCrowns} Total: {Wallet.totalWalletBalance} ";
            VendingMachine.vendingMachine = $"Vendingmachine: Total value: {VendingMachine.CurrentVendingBalance}";
            Bewerage bewerage = new Bewerage("Trocadero", "Fruity delicious swedish soda", "bewerage", 15);
            Bewerage bewerage1 = new Bewerage("Pommac", "Dark yellow festive Fizzypop", "bewerage", 15);
            Bewerage bewerage2 = new Bewerage("Cuba cola", "Sugary goodness", "Bewerage", 15);

            string[] productMenu =
            {
                    "Trocadero",
                    "Pommac",
                    "Cuba cola",
                    "Leave"
                };
            MenuSelector product = new MenuSelector(Menu.header, Wallet.wallet, VendingMachine.vendingMachine, productMenu);
            int topIndex = product.Navigate();

            switch (topIndex)
            {
                case 0:
                    BuyProductMenu(bewerage.Name, bewerage.Description, bewerage.Category, bewerage.Price);
                    break;

                case 1:
                    BuyProductMenu(bewerage1.Name, bewerage1.Description, bewerage1.Category, bewerage1.Price);
                    break;

                case 2:
                    BuyProductMenu(bewerage2.Name, bewerage2.Description, bewerage2.Category, bewerage2.Price);
                    break;

                case 3:
                    Menu.ProductCategorySelection();
                    break;
            }
        }

        public static void FoodSelection()
        {
            Wallet.wallet = $"Wallet: Krona: {Wallet.nrOfOneCrowns} Femma: {Wallet.nrOfFiveCrowns} Tia: {Wallet.nrOfTenCrowns} Total: {Wallet.totalWalletBalance}";
            VendingMachine.vendingMachine = $"Vendingmachine: Total value: {VendingMachine.CurrentVendingBalance}";
            Food food = new Food("Knäckesandwich", "For when you're desperatly hangry", "Food", 20);
            Food food1 = new Food("Marabou milkchocolate", "Melts in your mouth", "Food", 20);
            Food food2 = new Food("Falukorv", "Fast on the go snack", "Food", 20);

            string[] productMenu =
            {
                    "Knäckesandwich",
                    "Marabou milkchocolate",
                    "Falukorv",
                    "Leave"
                };
            MenuSelector product = new MenuSelector(Menu.header, Wallet.wallet, VendingMachine.vendingMachine, productMenu);
            int topIndex = product.Navigate();

            switch (topIndex)
            {
                case 0:
                    BuyProductMenu(food.Name, food.Description, food.Category, food.Price);
                    break;

                case 1:
                    BuyProductMenu(food1.Name, food1.Description, food1.Category, food1.Price);
                    break;

                case 2:
                    BuyProductMenu(food2.Name, food2.Description, food2.Category, food2.Price);
                    break;

                case 3:
                    Menu.ProductCategorySelection();
                    break;
            }
        }

        public static void UtilitySelection()
        {
            Wallet.wallet = $"Wallet: Krona: {Wallet.nrOfOneCrowns} Femma: {Wallet.nrOfFiveCrowns} Tia: {Wallet.nrOfTenCrowns} Total: {Wallet.totalWalletBalance}";
            VendingMachine.vendingMachine = $"Vendingmachine: Total value: {VendingMachine.CurrentVendingBalance}";
            Utility utility = new Utility("Wrench", "Practical and lethal", "Utility", 30);
            Utility utility1 = new Utility("Toilet paper", "A life saver", "Utility", 30);
            Utility utility2 = new Utility("Toothbrush", "Multipurpose superweapon", "Utility", 30);

            string[] productMenu =
            {
                    "Wrench",
                    "Toilet paper",
                    "Toothbrush",
                    "Leave"
                };
            MenuSelector product = new MenuSelector(Menu.header, Wallet.wallet, VendingMachine.vendingMachine, productMenu);
            int topIndex = product.Navigate();

            switch (topIndex)
            {
                case 0:
                    BuyProductMenu(utility.Name, utility.Description, utility.Category, utility.Price);
                    break;

                case 1:
                    BuyProductMenu(utility1.Name, utility1.Description, utility1.Category, utility1.Price);
                    break;

                case 2:
                    BuyProductMenu(utility2.Name, utility2.Description, utility2.Category, utility2.Price);
                    break;

                case 3:
                    Menu.ProductCategorySelection();
                    break;
            }
        }

        public static void GumSelection()
        {
            Wallet.wallet = $"Wallet: Krona: {Wallet.nrOfOneCrowns} Femma: {Wallet.nrOfFiveCrowns} Tia: {Wallet.nrOfTenCrowns} Total: {Wallet.totalWalletBalance}";
            VendingMachine.vendingMachine = $"Vendingmachine: Total value: {VendingMachine.CurrentVendingBalance}";
            Gum gum = new Gum("Jenka", "Sweet minty fresh", "Gum", 1);
            Gum gum1 = new Gum("Shake", "Ludicrous liqourice", "Gum", 1);
            Gum gum2 = new Gum("Hubba bubba", "Sour fruity fun time", "Gum", 1);

            string[] productMenu =
            {
                    "Jenka",
                    "Shake",
                    "Hubba bubba",
                    "Leave"
                };
            MenuSelector product = new MenuSelector(Menu.header, Wallet.wallet, VendingMachine.vendingMachine, productMenu);
            int topIndex = product.Navigate();

            switch (topIndex)
            {
                case 0:
                    BuyProductMenu(gum.Name, gum.Description, gum.Category, gum.Price);
                    break;

                case 1:
                    BuyProductMenu(gum1.Name, gum1.Description, gum1.Category, gum1.Price);
                    break;

                case 2:
                    BuyProductMenu(gum2.Name, gum2.Description, gum2.Category, gum2.Price);
                    break;

                case 3:
                    Menu.ProductCategorySelection();
                    break;
            }
        }

        public static void BuyProductMenu(string name, string description, string category, int price)
        {
            string[] productMenu =
            {
                    "Yes",
                    "No"
                };
            YesNoSelector product = new YesNoSelector(Menu.header, Wallet.wallet, name, description, category, price, VendingMachine.vendingMachine, productMenu);
            int topIndex = product.Navigate();

            switch (topIndex)
            {
                case 0:
                    if (VendingMachine.CurrentVendingBalance < price)
                    {
                        Console.WriteLine("Not enough coins in machine");
                        Console.ReadLine();
                        Menu.ProductCategorySelection();
                    }
                    else
                    {
                        BuyProduct(price);
                        Menu.ProductCategorySelection();
                    }
                    break;

                case 1:
                    Menu.ProductCategorySelection();

                    break;
            }
            return;
        }

        public static void BuyProduct(int price)
        {
            VendingMachine.CurrentVendingBalance -= price;
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

            if (price == 1)
            {
                Console.WriteLine("Chew chew chew");
            }
            else if (price == 15)
            {
                Console.WriteLine("Slurp slurp...");
            }
            else if (price == 20)
            {
                Console.WriteLine("Nom nom nom...");
            }
            else
            {
                Console.WriteLine("Tinker tinker...");
            }

            Console.WriteLine($"Your change is {changeOne} crowns {changeFive} fivecrowns {changeTen} tenners total crowns: {changeTotal}");
            Console.ReadLine();
        }
    }
}