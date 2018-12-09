using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    delegate void listOfSteps(Field field, ref bool itsLoose);
    interface IControls
    {
        string Acts { set; }
        event listOfSteps ListOfSteps;
    }
}
