namespace AutomatAoop
{
    public class Food : Product
    {
        //Food category product, instantiated in VendingMachine
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override string Category { get; set; }
        public override int Price { get; set; }
        public override string Effect { get; set; }

        public Food(string Name, string Description, int Price, string effect = "Nom nom nom")
        {
            this.Name = Name;
            this.Description = Description;
            this.Category = "Food";
            this.Price = Price;
            this.Effect = effect;
        }
    }
}