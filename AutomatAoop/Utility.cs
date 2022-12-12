namespace AutomatAoop
{
    public class Utility : Product
    {

        // Product class category utility
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override string Category { get; set; }
        public override int Price { get; set; }
        public override string Effect { get; set; }

        public Utility(string Name, string Description, int Price, string effect = "Tinker tinker")
        {
            this.Name = Name;
            this.Description = Description;
            this.Category = "Utility";
            this.Price = Price;
            this.Effect = effect;
        }
    }
}