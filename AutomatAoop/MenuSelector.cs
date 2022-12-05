namespace AutomatAoop
{
    public class MenuSelector
    {
        public int TopIndex;
        public string[] Options;
        private string Header;
        private string Footer;
        private string Vendingbalance;

        public MenuSelector(string header, string footer, string vendingbalance, string[] options)
        {
            Header = header;
            Footer = footer;
            Vendingbalance = vendingbalance;
            Options = options;
            TopIndex = 0;
        }

        private void ToggleOptions()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine(Header);
            for (int i = 0; i < Options.Length; i++)
            {
                string highlightedOption = Options[i];
                string highlight;

                if (i == TopIndex)
                {
                    highlight = "->";
                }
                else
                {
                    highlight = "-";
                }

                Console.WriteLine($"{highlight} {highlightedOption}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine(Footer);
            Console.WriteLine(Vendingbalance);
        }

        public int Navigate()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                ToggleOptions();
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                keyPressed = consoleKeyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    TopIndex--;
                    if (TopIndex == -1)
                    {
                        TopIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    TopIndex++;
                    if (TopIndex == Options.Length)
                    {
                        TopIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            return TopIndex;
        }
    }

    public class YesNoSelector
    {
        public int TopIndex;
        public string[] Options;
        private string Header;
        private string Footer;
        private string Name;
        private string Description;
        private string Category;
        private int Price;
        private string Vendingbalance;

        public YesNoSelector(string header, string footer, string name, string description, string category, int price, string vendingbalance, string[] options)
        {
            Header = header;
            Footer = footer;
            Name = name;
            Category = category;
            Price = price;
            Description = description;
            Vendingbalance = vendingbalance;
            Options = options;
            TopIndex = 0;
        }

        private void ToggleOptions()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine(Header);
            Console.WriteLine("");
            Console.WriteLine($"{Name}{Environment.NewLine}{Category}{Environment.NewLine}{Description}{Environment.NewLine}{Price}kr");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Buy This Product?");

            for (int i = 0; i < Options.Length; i++)
            {
                string highlightedOption = Options[i];
                string highlight;

                if (i == TopIndex)
                {
                    highlight = "->";
                }
                else
                {
                    highlight = "--";
                }

                Console.WriteLine($"{highlight} {highlightedOption}");
            }
            Console.WriteLine(Footer);
            Console.WriteLine(Vendingbalance);
        }

        public int Navigate()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                ToggleOptions();
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                keyPressed = consoleKeyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    TopIndex--;
                    if (TopIndex == -1)
                    {
                        TopIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    TopIndex++;
                    if (TopIndex == Options.Length)
                    {
                        TopIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            return TopIndex;
        }
    }
}