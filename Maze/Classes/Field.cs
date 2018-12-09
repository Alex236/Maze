using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    enum FieldElement
    {
        Empty,
        Wall,
        Finish
    }
    class Field
    {
        public FieldElement[,] GamingField { get; }
        public int SizeByY { get; }
        public int SizeByX { get; }
        public UserPosition CurrentUserPosition { get; set; }
        public UserPosition EndLevel { get; }
        public Field(int sizeByY, int sizeByX, int startY, int startx,
        int finishY, int finishX)
        {
            SizeByY = sizeByY;
            SizeByX = sizeByX;
            GamingField = new FieldElement[sizeByY, sizeByX];
            CurrentUserPosition = new UserPosition();
            EndLevel = new UserPosition();
            CurrentUserPosition.PositionY = startY;
            CurrentUserPosition.PositionX = startx;
            EndLevel.PositionY = finishY;
            EndLevel.PositionX = finishX;
        }
    }
}
