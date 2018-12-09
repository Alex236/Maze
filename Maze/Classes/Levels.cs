using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Levels
    {
        public static Field Level1()
        {
            Field field = new Field(5, 5, 2, 0, 0, 2);
            FieldLevel1(field);
            return field;
        }
        public static Field Level2()
        {
            Field field = new Field(7, 7, 2, 0, 0, 5);
            FieldLevel2(field);
            return field;
        }
        public static Field Level3()
        {
            Field field = new Field(14, 14, 6, 0, 5, 13);
            FieldLevel3(field);
            return field;
        }
        private static Field FieldLevel1(Field field)
        {
            for (int i = 0; i < field.SizeByY; i++)
            {
                field.GamingField[i, 0] = FieldElement.Wall;
                field.GamingField[i, field.SizeByX - 1] = FieldElement.Wall;
            }
            for (int i = 0; i < field.SizeByX; i++)
            {
                field.GamingField[0, i] = FieldElement.Wall;
                field.GamingField[field.SizeByY - 1, i] = FieldElement.Wall;
            }
            field.GamingField[1, 1] = FieldElement.Wall;
            field.GamingField[1, 2] = FieldElement.Empty;
            field.GamingField[1, 3] = FieldElement.Wall;
            field.GamingField[2, 1] = FieldElement.Empty;
            field.GamingField[2, 2] = FieldElement.Empty;
            field.GamingField[2, 3] = FieldElement.Wall;
            field.GamingField[3, 1] = FieldElement.Wall;
            field.GamingField[3, 2] = FieldElement.Wall;
            field.GamingField[3, 3] = FieldElement.Wall;
            field.GamingField[0, 2] = FieldElement.Finish;//end
            field.GamingField[2, 0] = FieldElement.Empty;//start
            return field;
        }
        private static Field FieldLevel2(Field field)
        {
            for (int i = 0; i < field.SizeByY; i++)
            {
                field.GamingField[i, 0] = FieldElement.Wall;
                field.GamingField[i, field.SizeByX - 1] = FieldElement.Wall;
            }
            for (int i = 0; i < field.SizeByX; i++)
            {
                field.GamingField[0, i] = FieldElement.Wall;
                field.GamingField[field.SizeByY - 1, i] = FieldElement.Wall;
            }
            field.GamingField[1, 1] = FieldElement.Empty;
            field.GamingField[1, 2] = FieldElement.Empty;
            field.GamingField[1, 3] = FieldElement.Empty;
            field.GamingField[1, 4] = FieldElement.Wall;
            field.GamingField[1, 5] = FieldElement.Empty;
            field.GamingField[2, 1] = FieldElement.Empty;
            field.GamingField[2, 2] = FieldElement.Wall;
            field.GamingField[2, 3] = FieldElement.Empty;
            field.GamingField[2, 4] = FieldElement.Wall;
            field.GamingField[2, 5] = FieldElement.Empty;
            field.GamingField[3, 1] = FieldElement.Wall;
            field.GamingField[3, 2] = FieldElement.Empty;
            field.GamingField[3, 3] = FieldElement.Empty;
            field.GamingField[3, 4] = FieldElement.Wall;
            field.GamingField[3, 5] = FieldElement.Empty;
            field.GamingField[4, 1] = FieldElement.Wall;
            field.GamingField[4, 2] = FieldElement.Empty;
            field.GamingField[4, 3] = FieldElement.Wall;
            field.GamingField[4, 4] = FieldElement.Wall;
            field.GamingField[4, 5] = FieldElement.Empty;
            field.GamingField[5, 1] = FieldElement.Wall;
            field.GamingField[5, 2] = FieldElement.Empty;
            field.GamingField[5, 3] = FieldElement.Empty;
            field.GamingField[5, 4] = FieldElement.Empty;
            field.GamingField[5, 5] = FieldElement.Empty;
            field.GamingField[2, 0] = FieldElement.Empty;//start
            field.GamingField[0, 5] = FieldElement.Finish;
            return field;
        }
        private static Field FieldLevel3(Field field)
        {
            for (int i = 0; i < field.SizeByY; i++)
            {
                field.GamingField[i, 0] = FieldElement.Wall;
                field.GamingField[i, field.SizeByX - 1] = FieldElement.Wall;
            }
            for (int i = 0; i < field.SizeByX; i++)
            {
                field.GamingField[0, i] = FieldElement.Wall;
                field.GamingField[field.SizeByY - 1, i] = FieldElement.Wall;
            }
            field.GamingField[1, 1] = FieldElement.Wall;
            field.GamingField[1, 2] = FieldElement.Wall;
            field.GamingField[1, 3] = FieldElement.Wall;
            field.GamingField[1, 4] = FieldElement.Wall;
            field.GamingField[1, 5] = FieldElement.Wall;
            field.GamingField[1, 6] = FieldElement.Wall;
            field.GamingField[1, 7] = FieldElement.Empty;
            field.GamingField[1, 8] = FieldElement.Empty;
            field.GamingField[1, 9] = FieldElement.Empty;
            field.GamingField[1, 10] = FieldElement.Empty;
            field.GamingField[1, 11] = FieldElement.Empty;
            field.GamingField[1, 12] = FieldElement.Empty;

            field.GamingField[2, 1] = FieldElement.Empty;
            field.GamingField[2, 2] = FieldElement.Empty;
            field.GamingField[2, 3] = FieldElement.Empty;
            field.GamingField[2, 4] = FieldElement.Empty;
            field.GamingField[2, 5] = FieldElement.Empty;
            field.GamingField[2, 6] = FieldElement.Wall;
            field.GamingField[2, 7] = FieldElement.Empty;
            field.GamingField[2, 8] = FieldElement.Wall;
            field.GamingField[2, 9] = FieldElement.Wall;
            field.GamingField[2, 10] = FieldElement.Wall;
            field.GamingField[2, 11] = FieldElement.Wall;
            field.GamingField[2, 12] = FieldElement.Empty;

            field.GamingField[3, 1] = FieldElement.Empty;
            field.GamingField[3, 2] = FieldElement.Wall;
            field.GamingField[3, 3] = FieldElement.Wall;
            field.GamingField[3, 4] = FieldElement.Wall;
            field.GamingField[3, 5] = FieldElement.Empty;
            field.GamingField[3, 6] = FieldElement.Empty;
            field.GamingField[3, 7] = FieldElement.Empty;
            field.GamingField[3, 8] = FieldElement.Wall;
            field.GamingField[3, 9] = FieldElement.Empty;
            field.GamingField[3, 10] = FieldElement.Empty;
            field.GamingField[3, 11] = FieldElement.Empty;
            field.GamingField[3, 12] = FieldElement.Empty;

            field.GamingField[4, 1] = FieldElement.Empty;
            field.GamingField[4, 2] = FieldElement.Empty;
            field.GamingField[4, 3] = FieldElement.Empty;
            field.GamingField[4, 4] = FieldElement.Wall;
            field.GamingField[4, 5] = FieldElement.Wall;
            field.GamingField[4, 6] = FieldElement.Wall;
            field.GamingField[4, 7] = FieldElement.Wall;
            field.GamingField[4, 8] = FieldElement.Wall;
            field.GamingField[4, 9] = FieldElement.Empty;
            field.GamingField[4, 10] = FieldElement.Wall;
            field.GamingField[4, 11] = FieldElement.Wall;
            field.GamingField[4, 12] = FieldElement.Wall;

            field.GamingField[5, 1] = FieldElement.Wall;
            field.GamingField[5, 2] = FieldElement.Wall;
            field.GamingField[5, 3] = FieldElement.Empty;
            field.GamingField[5, 4] = FieldElement.Wall;
            field.GamingField[5, 5] = FieldElement.Empty;
            field.GamingField[5, 6] = FieldElement.Empty;
            field.GamingField[5, 7] = FieldElement.Empty;
            field.GamingField[5, 8] = FieldElement.Empty;
            field.GamingField[5, 9] = FieldElement.Empty;
            field.GamingField[5, 10] = FieldElement.Wall;
            field.GamingField[5, 11] = FieldElement.Empty;
            field.GamingField[5, 12] = FieldElement.Empty;

            field.GamingField[6, 1] = FieldElement.Empty;
            field.GamingField[6, 2] = FieldElement.Wall;
            field.GamingField[6, 3] = FieldElement.Empty;
            field.GamingField[6, 4] = FieldElement.Wall;
            field.GamingField[6, 5] = FieldElement.Empty;
            field.GamingField[6, 6] = FieldElement.Wall;
            field.GamingField[6, 7] = FieldElement.Wall;
            field.GamingField[6, 8] = FieldElement.Wall;
            field.GamingField[6, 9] = FieldElement.Wall;
            field.GamingField[6, 10] = FieldElement.Wall;
            field.GamingField[6, 11] = FieldElement.Empty;
            field.GamingField[6, 12] = FieldElement.Wall;

            field.GamingField[7, 1] = FieldElement.Empty;
            field.GamingField[7, 2] = FieldElement.Wall;
            field.GamingField[7, 3] = FieldElement.Empty;
            field.GamingField[7, 4] = FieldElement.Wall;
            field.GamingField[7, 5] = FieldElement.Empty;
            field.GamingField[7, 6] = FieldElement.Wall;
            field.GamingField[7, 7] = FieldElement.Wall;
            field.GamingField[7, 8] = FieldElement.Wall;
            field.GamingField[7, 9] = FieldElement.Empty;
            field.GamingField[7, 10] = FieldElement.Empty;
            field.GamingField[7, 11] = FieldElement.Empty;
            field.GamingField[7, 12] = FieldElement.Wall;

            field.GamingField[8, 1] = FieldElement.Empty;
            field.GamingField[8, 2] = FieldElement.Empty;
            field.GamingField[8, 3] = FieldElement.Empty;
            field.GamingField[8, 4] = FieldElement.Wall;
            field.GamingField[8, 5] = FieldElement.Empty;
            field.GamingField[8, 6] = FieldElement.Wall;
            field.GamingField[8, 7] = FieldElement.Wall;
            field.GamingField[8, 8] = FieldElement.Wall;
            field.GamingField[8, 9] = FieldElement.Empty;
            field.GamingField[8, 10] = FieldElement.Wall;
            field.GamingField[8, 11] = FieldElement.Wall;
            field.GamingField[8, 12] = FieldElement.Wall;

            field.GamingField[9, 1] = FieldElement.Wall;
            field.GamingField[9, 2] = FieldElement.Wall;
            field.GamingField[9, 3] = FieldElement.Wall;
            field.GamingField[9, 4] = FieldElement.Empty;
            field.GamingField[9, 5] = FieldElement.Empty;
            field.GamingField[9, 6] = FieldElement.Wall;
            field.GamingField[9, 7] = FieldElement.Wall;
            field.GamingField[9, 8] = FieldElement.Wall;
            field.GamingField[9, 9] = FieldElement.Empty;
            field.GamingField[9, 10] = FieldElement.Empty;
            field.GamingField[9, 11] = FieldElement.Wall;
            field.GamingField[9, 12] = FieldElement.Wall;

            field.GamingField[10, 1] = FieldElement.Empty;
            field.GamingField[10, 2] = FieldElement.Empty;
            field.GamingField[10, 3] = FieldElement.Empty;
            field.GamingField[10, 4] = FieldElement.Empty;
            field.GamingField[10, 5] = FieldElement.Wall;
            field.GamingField[10, 6] = FieldElement.Empty;
            field.GamingField[10, 7] = FieldElement.Empty;
            field.GamingField[10, 8] = FieldElement.Empty;
            field.GamingField[10, 9] = FieldElement.Wall;
            field.GamingField[10, 10] = FieldElement.Empty;
            field.GamingField[10, 11] = FieldElement.Empty;
            field.GamingField[10, 12] = FieldElement.Empty;

            field.GamingField[11, 1] = FieldElement.Empty;
            field.GamingField[11, 2] = FieldElement.Wall;
            field.GamingField[11, 3] = FieldElement.Wall;
            field.GamingField[11, 4] = FieldElement.Wall;
            field.GamingField[11, 5] = FieldElement.Wall;
            field.GamingField[11, 6] = FieldElement.Empty;
            field.GamingField[11, 7] = FieldElement.Wall;
            field.GamingField[11, 8] = FieldElement.Empty;
            field.GamingField[11, 9] = FieldElement.Wall;
            field.GamingField[11, 10] = FieldElement.Wall;
            field.GamingField[11, 11] = FieldElement.Wall;
            field.GamingField[11, 12] = FieldElement.Empty;

            field.GamingField[12, 1] = FieldElement.Empty;
            field.GamingField[12, 2] = FieldElement.Empty;
            field.GamingField[12, 3] = FieldElement.Empty;
            field.GamingField[12, 4] = FieldElement.Empty;
            field.GamingField[12, 5] = FieldElement.Empty;
            field.GamingField[12, 6] = FieldElement.Empty;
            field.GamingField[12, 7] = FieldElement.Wall;
            field.GamingField[12, 8] = FieldElement.Empty;
            field.GamingField[12, 9] = FieldElement.Empty;
            field.GamingField[12, 10] = FieldElement.Empty;
            field.GamingField[12, 11] = FieldElement.Empty;
            field.GamingField[12, 12] = FieldElement.Empty;

            field.GamingField[6, 0] = FieldElement.Empty;
            field.GamingField[5, 13] = FieldElement.Finish;
            return field;
        }
    }
}
