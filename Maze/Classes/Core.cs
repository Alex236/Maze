using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Core
    {
        public int Level { private get; set; }
        private Field field;
        public void SetLevel()
        {
            switch (Level)
            {
                case 1:
                    field = Levels.Level1();
                    break;
                case 2:
                    field = Levels.Level2();
                    break;
                case 3:
                    field = Levels.Level3();
                    break;
            }
            switch(StartGame())
            {
                case Result.Win:
                    Console.WriteLine("Win");
                    break;
                case Result.Loose:
                    Console.WriteLine("Loose");
                    break;
            }
        }
        private Result StartGame()
        {
            Display display = new Display();
            display.CurrentStateOfField = field;
            display.DisplayField();

            Controls controls = new Controls();
            Console.WriteLine("Input controls");
            bool correctInput = false;
            string acts = "";
            while (!correctInput)
            {
                acts = Console.ReadLine();
                correctInput = CheckUsetInput(acts);
            }
            controls.Acts = acts;
            bool itsLoose = false;
            controls.CreateListOfActs().Invoke(field, ref itsLoose);
            if (itsLoose || !(Equals(field.CurrentUserPosition,field.EndLevel))) return Result.Loose;
            return Result.Win;
        }
        private bool CheckUsetInput(string str)
        {
            int counter = 0;
            foreach (var e in str)
            {
                if (e == 'w' || e == 'a' || e == 's' || e == 'd') counter++;
            }
            return counter == str.Length;
        }
    }
}
