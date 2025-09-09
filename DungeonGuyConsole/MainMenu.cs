using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;
namespace DungeonGuyConsole
{
    internal class MainMenu
    {
        private const int MinOption = 1;
        private const int MaxOption = 3;
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
            _displayMenu();
        }

        private void _displayMenu()
        {
            while (true)
            {
                Console.WriteLine("1. New Game");
                Console.WriteLine("2. Continue");
                Console.WriteLine("3. Help");
                string selection = Console.ReadLine();

                if (_validateMenuSelection(selection, out int selectionInt))
                {
                    _executeMenuSelection(selectionInt);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please enter a number between 1 and 3.");
                }
            }
        }

        private bool _validateMenuSelection(string selection, out int selectionInt)
        {
            selectionInt = 0;
            return int.TryParse(selection, out selectionInt) && selectionInt >= MinOption && selectionInt <= MaxOption;
        }

        private void _executeMenuSelection(int selection)
        {
            CharacterMenu characterMenu = new CharacterMenu();
            switch (selection)
            {
                case 1:
                    characterMenu.CharacterMenuText();
                    break;
                case 2:
                    break;
                case 3:
                    _displayHelpText();
                    _displayMenu();
                    break;
            }
        }

        private void _displayHelpText()
        {
            Console.WriteLine("Help Text Here");
        }
    }
}