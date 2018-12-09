using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class UserPosition
    {
        public int PositionY { get; set; }
        public int PositionX { get; set; }
        public override string ToString()
        {
            return string.Format($"{PositionX} {PositionY}");
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            return (this.ToString() == ((UserPosition)obj).ToString());
        }
    }
}
