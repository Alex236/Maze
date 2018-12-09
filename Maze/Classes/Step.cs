using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    enum StepTo
    {
        W,
        A,
        S,
        D
    }
    class Step : IStep
    {
        public void StepW(Field field, ref bool itsLoose)
        {
            if (NewPosition(field, StepTo.W) == Result.Loose) itsLoose = true;
        }
        public void StepA(Field field, ref bool itsLoose)
        {
            if (NewPosition(field, StepTo.A) == Result.Loose) itsLoose = true;
        }
        public void StepS(Field field, ref bool itsLoose)
        {
            if (NewPosition(field, StepTo.S) == Result.Loose) itsLoose = true;
        }
        public void StepD(Field field, ref bool itsLoose)
        {
            if (NewPosition(field, StepTo.D) == Result.Loose) itsLoose = true;
        }
        private Result NewPosition(Field field, StepTo stepTo)
        {
            switch(stepTo)
            {
                case StepTo.W:
                    return CheckNextStepW(field);
                case StepTo.A:
                    return CheckNextStepA(field);
                case StepTo.S:
                    return CheckNextStepS(field);
                case StepTo.D:
                    return CheckNextStepD(field);
            }
            return Result.Loose;
        }
        private Result CheckNextStepW(Field field)
        {
            if (field.CurrentUserPosition.PositionY <= 0 || field.CurrentUserPosition.PositionY >= field.GamingField.Length - 1 ||
                field.CurrentUserPosition.PositionX < 0 || field.CurrentUserPosition.PositionX >= field.GamingField.Length - 1)
                return Result.Loose;
            switch(field.GamingField[field.CurrentUserPosition.PositionY-1, field.CurrentUserPosition.PositionX])
            {
                case FieldElement.Empty:
                    field.CurrentUserPosition.PositionY -= 1;
                    Display.DisplayField(field, Result.InProcess);
                    return Result.InProcess;
                case FieldElement.Wall:
                    Display.DisplayField(field, Result.Loose);
                    return Result.Loose;
                case FieldElement.Finish:
                    field.CurrentUserPosition.PositionY -= 1;
                    Display.DisplayField(field, Result.Win);
                    return Result.Win;
            }
            return Result.Loose;
        }
        private Result CheckNextStepA(Field field)
        {
            if (field.CurrentUserPosition.PositionY < 0 || field.CurrentUserPosition.PositionY >= field.GamingField.Length - 1 ||
                field.CurrentUserPosition.PositionX <= 0 || field.CurrentUserPosition.PositionX >= field.GamingField.Length - 1)
                return Result.Loose;
            switch (field.GamingField[field.CurrentUserPosition.PositionY, field.CurrentUserPosition.PositionX - 1])
            {
                case FieldElement.Empty:
                    field.CurrentUserPosition.PositionX -= 1;
                    Display.DisplayField(field, Result.InProcess);
                    return Result.InProcess;
                case FieldElement.Wall:
                    Display.DisplayField(field, Result.Loose);
                    return Result.Loose;
                case FieldElement.Finish:
                    field.CurrentUserPosition.PositionX -= 1;
                    Display.DisplayField(field, Result.Win);
                    return Result.Win;
            }
            return Result.Loose;
        }
        private Result CheckNextStepS(Field field)
        {
            if (field.CurrentUserPosition.PositionY < 0 || field.CurrentUserPosition.PositionY >= field.GamingField.Length - 2 ||
                field.CurrentUserPosition.PositionX < 0 || field.CurrentUserPosition.PositionX >= field.GamingField.Length - 1)
                return Result.Loose;
            switch (field.GamingField[field.CurrentUserPosition.PositionY + 1, field.CurrentUserPosition.PositionX])
            {
                case FieldElement.Empty:
                    field.CurrentUserPosition.PositionY += 1;
                    Display.DisplayField(field, Result.InProcess);
                    return Result.InProcess;
                case FieldElement.Wall:
                    Display.DisplayField(field, Result.Loose);
                    return Result.Loose;
                case FieldElement.Finish:
                    field.CurrentUserPosition.PositionY += 1;
                    Display.DisplayField(field, Result.Win);
                    return Result.Win;
            }
            return Result.Loose;
        }
        private Result CheckNextStepD(Field field)
        {
            if (field.CurrentUserPosition.PositionY < 0 || field.CurrentUserPosition.PositionY >= field.GamingField.Length - 1 ||
                field.CurrentUserPosition.PositionX < 0 || field.CurrentUserPosition.PositionX >= field.GamingField.Length - 2)
                return Result.Loose;
            switch (field.GamingField[field.CurrentUserPosition.PositionY, field.CurrentUserPosition.PositionX + 1])
            {
                case FieldElement.Empty:
                    field.CurrentUserPosition.PositionX += 1;
                    Display.DisplayField(field, Result.InProcess);
                    return Result.InProcess;
                case FieldElement.Wall:
                    Display.DisplayField(field, Result.Loose);
                    return Result.Loose;
                case FieldElement.Finish:
                    field.CurrentUserPosition.PositionX += 1;
                    Display.DisplayField(field, Result.Win);
                    return Result.Win;
            }
            return Result.Loose;
        }
    }
}
