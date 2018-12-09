using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Controls : IControls
    {
        public string Acts { private get; set; }
        public event listOfSteps ListOfSteps;
        public listOfSteps CreateListOfActs()
        {
            Step step = new Step();
            foreach (var e in Acts)
            {
                switch (e)
                {
                    case 'w':
                        ListOfSteps += step.StepW;
                        break;
                    case 'a':
                        ListOfSteps += step.StepA;
                        break;
                    case 's':
                        ListOfSteps += step.StepS;
                        break;
                    case 'd':
                        ListOfSteps += step.StepD;
                        break;
                }
            }
            return ListOfSteps;
        }
    }
}
