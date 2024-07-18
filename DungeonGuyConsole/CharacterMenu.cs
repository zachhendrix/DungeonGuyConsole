using System;
using System.Text.RegularExpressions;
using static DungeonGuyConsole.Character.CharacterClass;
using static DungeonGuyConsole.Character.CharacterRace;

namespace DungeonGuyConsole
{
    internal class CharacterMenu
    {
        private const int _minNameLength = 3;
        private const int _maxNameLength = 14;
        public Character.Character character = new Character.Character();

        public void CharacterMenuText()
        {
            Console.WriteLine("Welcome to Dungeon Guy");
            _setCharacterName();
            _setCharacterRace();
            _setCharacterJob();
            Console.WriteLine($"{character.Name} {character.Race} {character.Job}");
        }

        private void _setCharacterName()
        {
            while (true)
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                if (_validateName(name))
                {
                    character.Name = name;
                    break;
                }
                Console.WriteLine($"Name must be between {_minNameLength} and {_maxNameLength} characters. Please try again.");
            }
        }

        private void _setCharacterRace()
        {
            while (true)
            {
                Console.WriteLine("What are you?");
                foreach (Race race in Enum.GetValues(typeof(Race)))
                {
                    Console.WriteLine($"{(int)race + 1}. {race}");
                }

                string raceSelection = Console.ReadLine();
                if (_validateSelection(raceSelection, Enum.GetValues(typeof(Race)).Length, out int selectionInt))
                {
                    character.Race = (Race)(selectionInt - 1);
                    break;
                }
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        private void _setCharacterJob()
        {
            while (true)
            {
                Console.WriteLine("What do you excel in?");
                foreach (Job job in Enum.GetValues(typeof(Job)))
                {
                    Console.WriteLine($"{(int)job + 1}. {job}");
                }

                string jobSelection = Console.ReadLine();
                if (_validateSelection(jobSelection, Enum.GetValues(typeof(Job)).Length, out int selectionInt))
                {
                    character.Job = (Job)(selectionInt - 1);
                    break;
                }
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        private bool _validateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Length >= _minNameLength && name.Length <= _maxNameLength;
        }

        private bool _validateSelection(string input, int maxOption, out int selection)
        {
            selection = 0;
            return int.TryParse(input, out selection) && selection > 0 && selection <= maxOption;
        }
    }
}
