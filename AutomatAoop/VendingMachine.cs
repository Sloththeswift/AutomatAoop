namespace AutomatAoop
{
    public static class VendingMachine
    {
        public static int CurrentVendingBalance { get; set; }
        public static volatile string vendingMachine = $"Vendingmachine: Total value: {CurrentVendingBalance}";
    }
}