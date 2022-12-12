using static System.Console;

namespace AutomatAoop
{
    public class MenuSelector //Skeleton for menu and navigation, uses indexes of string arrays as menus, reads indexes and inputs from user via keys, and console width to determine layouts. 
    {
        public int TopIndex;
        public string[] Options;
        private string Header;
        private string Footer;
        private string Vendingbalance;

        public static int menuPosition;
        public int DrawMenuColumnPos;
        public readonly int DrawMenuRowPos;
        public int CurrentSelection;
        private int MenuMaximumWidth;

        public MenuSelector(string header, string footer, string vendingbalance, string[] options, int row, int col)
        {
            Header = header;
            Footer = footer;
            Vendingbalance = vendingbalance;
            Options = options;
            TopIndex = 0;
            DrawMenuRowPos = row;
            DrawMenuColumnPos = col;
        }


        //Determines layout position of output
        public void SetCursorPosition(int row, int column)
        {
            if (row > 0 && row < WindowHeight)
            {
                CursorTop = row;
            }

            if (column > 0 && column < WindowWidth)
            {
                CursorLeft = column;
            }
        }

        //Using this for selected option
        public void SetConsoleTextColor(ConsoleColor foreground, ConsoleColor background)
        {
            ForegroundColor = foreground;
            BackgroundColor = background;
        }

        //Prevents flickering of cursor line 
        public void ResetCursorVisible()
        {
            CursorVisible = CursorVisible != true;
        }

        //Changes color depending on if object is in focus
        private void ToggleOptions()
        {
            
            for (int i = 0; i < Options.Length; i++)
            {
                string highlightedOption = Options[i];               
                SetCursorPosition(DrawMenuRowPos + i, DrawMenuColumnPos);
                SetConsoleTextColor(ConsoleColor.White, ConsoleColor.Black);
                if (i == TopIndex)
                {
                    SetConsoleTextColor(ConsoleColor.Black, ConsoleColor.White);
                    
                }
                
                Console.WriteLine(highlightedOption);
                ResetColor();
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine(Footer);
            Console.WriteLine(Vendingbalance);
        }

        //Maps keys and manipulates index value for menu control
        public int Navigate()
        {
            ConsoleKey keyPressed;
            do
            {
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
            Console.Clear();
            return TopIndex;
        }
    }

    // Created a separate menu skeleton for purchasing, faster than debugging at the moment, probably fix it after deadline. Basically a copy of menuselector.
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
        public static int menuPosition;
        public int DrawMenuColumnPos;
        public readonly int DrawMenuRowPos;
        public int CurrentSelection;
        private int MenuMaximumWidth;

        public YesNoSelector(string header, string footer, string name, string description, string category, int price, string vendingbalance, int row, int col, string[] options)
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
            DrawMenuRowPos = row;
            DrawMenuColumnPos = col;
        }

        public void SetCursorPosition(int row, int column)
        {
            if (row > 0 && row < WindowHeight)
            {
                CursorTop = row;
            }

            if (column > 0 && column < WindowWidth)
            {
                CursorLeft = column;
            }
        }

        public void SetConsoleTextColor(ConsoleColor foreground, ConsoleColor background)
        {
            ForegroundColor = foreground;
            BackgroundColor = background;
        }


        public static int ConsoleWindowWidth()
        {
            return Console.WindowWidth;
        }

        public void ToggleOptions()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine(Header);
            Console.WriteLine("");
            Console.WriteLine($"{Name}{Environment.NewLine}{Category}{Environment.NewLine}{Description}{Environment.NewLine}{Price}kr");
            Console.WriteLine("");
            Console.WriteLine("Buy This Product?");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine(Footer);
            Console.WriteLine(Vendingbalance);

           

            for (int i = 0; i < Options.Length; i++)
            {              

                string highlightedOption = Options[i];
                SetCursorPosition(DrawMenuRowPos + i, DrawMenuColumnPos);
                SetConsoleTextColor(ConsoleColor.White, ConsoleColor.Black);
                if (i == TopIndex)
                {
                    SetConsoleTextColor(ConsoleColor.Black, ConsoleColor.White);
                }
                Console.WriteLine(highlightedOption);
                ResetColor();
               
            }
        }

        public int Navigates()
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
            Console.Clear();
            return TopIndex;
        }
    }
}