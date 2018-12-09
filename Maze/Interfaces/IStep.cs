using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    interface IStep
    {
        void StepW(Field field, ref bool itsLoose);
        void StepA(Field field, ref bool itsLoose);
        void StepS(Field field, ref bool itsLoose);
        void StepD(Field field, ref bool itsLoose);
    }
}
