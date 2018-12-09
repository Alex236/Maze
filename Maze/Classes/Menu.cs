using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Menu
    {
        public Menu()
        {
            while (true)
            {
                Play();
                Console.WriteLine("Press enter to countinue");
                Console.ReadKey();
            }
        }
        private void Play()
        {
            DisplayRules();
            Core core = new Core();
            core.Level = ChooseLevel();
            core.SetLevel();
        }
        private void DisplayRules()
        {
            Console.WriteLine("This is a Maze.\n" +
                "Rules are easy)\n" +
                "Use WASD (in lower case) to find exit.\n" +
                "Input yor way (example: the way of first level is \"ddww\")");//change
        }
        private int ChooseLevel()
        {
            bool inputCorrect = false;
            int userInput = 0;
            while (!inputCorrect)
            {
                DisplayLevels();
                inputCorrect = int.TryParse(Console.ReadLine(), out userInput);
            }
            Console.Clear();
            return userInput;
        }
        private void DisplayLevels()
        {
            Console.WriteLine("\nChoose level (input only number):\n" +
                "Level 1\n" +
                "Level 2\n" +
                "Level 3\n");//change
        }
    }
}
