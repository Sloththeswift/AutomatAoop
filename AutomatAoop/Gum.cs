namespace AutomatAoop
{
    public class Gum : Product
    {
        //Gum category product, instantiated in VendingMachine
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override string Category { get; set; }
        public override int Price { get; set; }
        public override string Effect { get; set; }

        public Gum(string Name, string Description, int Price, string effect = "Chew chew")
        {
            this.Name = Name;
            this.Description = Description;
            this.Category = "Gum";
            this.Price = Price;
            this.Effect = effect;
        }
    }
}