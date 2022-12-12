namespace AutomatAoop
{
    public static class VendingMachine
    {
        // This acts as the vendingmachines "Wallet" and the volatile string is also used as a footer to display it
        public static int CurrentVendingBalance { get; set; }
        public static volatile string vendingMachine = $"Vendingmachine: Total value: {CurrentVendingBalance}";

        //list of all the products that gets sorted by category in the product class
        public static List<Product> productList = new List<Product>()
            {
                new Gum("Jenka", "Sweet minty fresh", 1),
                new Gum("Shake", "Ludicrous liqourice", 1),
                new Gum("Hubba bubba", "Sour fruity fun time", 1),
                new Utility("Wrench", "Practical and lethal", 30),
                new Utility("Toilet paper", "A life saver", 30),
                new Utility("Toothbrush", "Multipurpose superweapon", 30),
                new Food("Knäckesandwich", "For when you're desperatly hangry", 20),
                new Food("Marabou milkchocolate", "Melts in your mouth", 20),
                new Food("Falukorv", "Fast on the go snack", 20),
                new Bewerage("Trocadero", "Fruity delicious swedish soda", 15),
                new Bewerage("Pommac", "Dark yellow festive Fizzypop", 15),
                new Bewerage("Cuba cola", "Sugary goodness", 15)
            };
    }
}