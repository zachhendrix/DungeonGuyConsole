using System.Text.RegularExpressions;
namespace DungeonGuyConsole
{
    internal class UtilityMenu
    {
        public void TitleText()
        {
            Console.WriteLine("Hello, and welcome to: ");
            Console.WriteLine("  _____                                        _____             \r\n" +
                              " |  __ \\                                      / ____|            \r\n" +
                              " | |  | |_   _ _ __   __ _  ___  ___  _ __   | |  __ _   _ _   _ \r\n" +
                              " | |  | | | | | '_ \\ / _` |/ _ \\/ _ \\| '_ \\  | | |_ | | | | | | |\r\n" +
                              " | |__| | |_| | | | | (_| |  __/ (_) | | | | | |__| | |_| | |_| |\r\n" +
                              " |_____/ \\__,_|_| |_|\\__, |\\___|\\___/|_| |_|  \\_____|\\__,_|\\__, |\r\n" +
                              "                      __/ |                                 __/ |\r\n" +
                              "                     |___/                                 |___/ ");
            _menuPrint();
        }

        private void _menuPrint()
        {
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Continue");
            Console.WriteLine("3. Help");
            string selection = Console.ReadLine();
            _menuSelectionValidation(selection);
        }

        private void _menuSelectionValidation(string selection)
        {
            Regex regex = new Regex(@"^\d+$");
            if (regex.IsMatch(selection))
            {
                int selectionInt = int.Parse(selection);
                if (selectionInt > 0 && selectionInt < 4)
                {
                    _menuSelection(selectionInt);
                }
                else
                {
                    Console.WriteLine("Enter a number within range");
                    _menuPrint();
                }
            }
            else if (!regex.IsMatch(selection))
            {
                Console.WriteLine("Invalid selection: Please enter only numbers.");
                _menuPrint();
            }
            else
            {
                Console.WriteLine("Dont do that...");
                _menuPrint();
            }
        }

        private void _menuSelection(int selection)
        {
            CharacterMenu characterMenu = new CharacterMenu();
            switch(selection)
            {
                case 1:
                    characterMenu.CharacterMenuText();
                    break;
                case 2:
                    break;
                case 3:
                    _helpText();
                    _menuPrint();
                    break;
            }
        }

        private void _helpText()
        {
            Console.WriteLine("Help Text Here");
        }
    }
}
