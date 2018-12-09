using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Maze
{
    class Display : IDisplay
    {
        public Field CurrentStateOfField { private get; set; }
        public void DisplayField()
        {
            for (int i = 0; i < CurrentStateOfField.SizeByY; i++)
            {
                for (int j = 0; j < CurrentStateOfField.SizeByX; j++)
                {
                    if (CurrentStateOfField.CurrentUserPosition.PositionX == j && CurrentStateOfField.CurrentUserPosition.PositionY == i)
                        Console.Write("*");
                    else
                    {
                        switch (CurrentStateOfField.GamingField[i, j])
                        {
                            case FieldElement.Empty:
                                Console.Write(" ");
                                break;
                            case FieldElement.Wall:
                                Console.Write("#");
                                break;
                            case FieldElement.Finish:
                                Console.Write(" ");
                                break;
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        public static void DisplayField(Field field, Result result)
        {
            Console.Clear();
            for (int i = 0; i < field.SizeByY; i++)
            {
                for (int j = 0; j < field.SizeByX; j++)
                {
                    if (field.CurrentUserPosition.PositionY == i && field.CurrentUserPosition.PositionX == j &&
                        (result == Result.Win || result == Result.InProcess))
                        Console.Write("*");
                    else if (field.CurrentUserPosition.PositionY == i && field.CurrentUserPosition.PositionX == j && result == Result.Loose)
                        Console.Write("X");
                    else
                    {
                        switch (field.GamingField[i, j])
                        {
                            case FieldElement.Empty:
                                Console.Write(" ");
                                break;
                            case FieldElement.Wall:
                                Console.Write("#");
                                break;
                            case FieldElement.Finish:
                                Console.Write(" ");
                                break;
                        }
                    }
                }
                Console.WriteLine();
            }
            Thread.Sleep(1000);
        }
    }
}
