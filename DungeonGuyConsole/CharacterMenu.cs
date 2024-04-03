using System.Text.RegularExpressions;
using static DungeonGuyConsole.Character.CharacterClass;
using static DungeonGuyConsole.Character.CharacterRace;

namespace DungeonGuyConsole
{
    internal class CharacterMenu
    {
        public Character.Character character = new Character.Character();

        public void CharacterMenuText()
        {
            Console.WriteLine("Welcome to Dungeon Guy");
            _setCharacterName();
            _setCharacterRace();
            _setCharacterJob();
            Console.WriteLine((string)(character.Name + " " + character.Race + " " + character.Job));
        }

        private void _setCharacterName()
        {
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            _nameValidator(name);
            character.Name = name;
        }

        private void _setCharacterRace()
        {
            Console.WriteLine("What are you?");
            foreach (Race race in Enum.GetValues(typeof(Race)))
            {
                Console.WriteLine($"{(int)race + 1} . {race}");
            }
            string raceSelection = Console.ReadLine();
            int selectionInt = _raceValidator(raceSelection);
            character.Race = (Race)selectionInt - 1;
        }

        private void _setCharacterJob() 
        {
            Console.WriteLine("What do you excel in?");
            foreach (Job job in Enum.GetValues(typeof(Job)))
            {
                Console.WriteLine($"{(int)job + 1} . {job}");
            }
            string jobSelection = Console.ReadLine();
            int selectionInt = _jobValidator(jobSelection);
            character.Job = (Job)selectionInt - 1;
        }

        private string _nameValidator(string name)
        {
            Regex regex = new Regex(@"^.{3,14}$");

            if (regex.IsMatch(name))
            {
                return name;
            }
            else
            {
                Console.WriteLine("Name must have more than 2 characters and less than 15 characters. Please try again.");
                _setCharacterName();
            }
            return "ErrorName";
        }

        private int _raceValidator(string raceSelection)
        {
            Regex regex = new Regex(@"^\d+$");
            if (regex.IsMatch(raceSelection))
            {
                int selectionInt = int.Parse(raceSelection);
                return selectionInt;
            }
            else
            {
                Console.WriteLine("Please select a number");
                _setCharacterRace();
            }
            return 1;
        }

        private int _jobValidator(string jobSelection)
        {
            Regex regex = new Regex(@"^\d+$");
            if (regex.IsMatch(jobSelection))
            {
                int selectionInt = int.Parse(jobSelection);
                return selectionInt;
            }
            else
            {
                Console.WriteLine("Please select a number");
                _setCharacterJob();
            }
            return 1;
        }
    }
}
