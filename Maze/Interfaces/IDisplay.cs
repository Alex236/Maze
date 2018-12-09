using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    interface IDisplay
    {
        Field CurrentStateOfField { set; }
        void DisplayField();
    }
}
