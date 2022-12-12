namespace AutomatAoop
{
    public class Bewerage : Product
    {
        //Bewerage category product, instantiated in VendingMachine 
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override string Category { get; set; }
        public override int Price { get; set; }
        public override string Effect { get; set; }

        public Bewerage(string Name, string Description, int Price, string effect = "Slurp slurp")
        {
            this.Name = Name;
            this.Description = Description;
            this.Category = "Bewerage";
            this.Price = Price;
            this.Effect = effect;
        }
    }
}