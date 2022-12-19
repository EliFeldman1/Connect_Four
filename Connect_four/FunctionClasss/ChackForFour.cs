using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_four
{
    internal class ChackForFour
    {

        
        public bool DiagonalRightUpTest(gameBoardModel gameBoard, PointAddingModel PointAdding)
        {
            // this function chack's if the bord has four points Diagonally, and this when the right side is the bottom
            PointAdding.startPointRow = Math.Max(0, (PointAdding.Row - 3));
            PointAdding.endPointRow = Math.Min(6, (PointAdding.Row + 3));
            PointAdding.startPointColumn = Math.Max(0, PointAdding.Column - 3);
            PointAdding.endPointColumn = Math.Min(5, PointAdding.Column + 3);
            //compares coordinates of the starting point, in order to return one uniform point
            int deltaStart = ComparisonStart(PointAdding);
            
                PointAdding.startPointRow = PointAdding.Row - deltaStart;
                PointAdding.startPointColumn = PointAdding.Column - deltaStart;

            //compares coordinates of the ending point, in order to return one uniform point
            int deltaEnd = ComparisonEnd(PointAdding);
            
            
                PointAdding.endPointRow = PointAdding.Row + deltaEnd;
                PointAdding.endPointColumn= PointAdding.Column + deltaEnd;
            
            int counter = 0;
            for (int i = 0; PointAdding.startPointRow + i < PointAdding.endPointRow + 1 || PointAdding.startPointColumn + i < PointAdding.endPointColumn + 1; i++)
            {
                if (gameBoard.Board[PointAdding.startPointRow + i, PointAdding.startPointColumn + i] == PointAdding.CurrentPlayer)
                {
                    counter++;
                    if (counter == 4)
                    {
                        return true;
                    }

                }
                else
                {
                    counter = 0;
                }

            }

            return false;
        }
        public bool DiagonalRightDownTest(gameBoardModel gameBoard, PointAddingModel PointAdding)
        {
            // this function chack's if the bord has four points Diagonally, and this when the right side is the bottom
            PointAdding.startPointRow = Math.Max(0, (PointAdding.Row - 3));
            PointAdding.endPointRow = Math.Min(6, (PointAdding.Row + 3));
            PointAdding.startPointColumn = Math.Min(5, PointAdding.Column + 3);
            PointAdding.endPointColumn = Math.Max(0, PointAdding.Column - 3);
            //compares coordinates of the starting point, in order to return one uniform point
            int deltaStart = ComparisonStart(PointAdding);
            
                PointAdding.startPointRow = PointAdding.Row +deltaStart;
                PointAdding.startPointColumn = PointAdding.Column - deltaStart;

            //compares coordinates of the ending point, in order to return one uniform point
            int deltaEnd = ComparisonEnd(PointAdding);
            
                PointAdding.endPointRow = PointAdding.Row - deltaEnd;
                PointAdding.endPointColumn = PointAdding.Column + deltaEnd;
            
            int counter = 0;
            for (int i = 0; PointAdding.startPointRow + i < PointAdding.endPointRow + 1 || PointAdding.startPointColumn + i > PointAdding.endPointColumn + 1; i++)
            {
                if (gameBoard.Board[PointAdding.startPointRow + i, PointAdding.startPointColumn - i] == PointAdding.CurrentPlayer)
                {
                    counter++;
                    if (counter == 4)
                    {
                        return true;
                    }

                }
                else
                {
                    counter = 0;
                }

            }

            return false;
        }
      

        public bool HorizontalTest(gameBoardModel gameBoard, PointAddingModel PointAdding)
        {
            // this function chack's if the bord has four points Horizontal.
            PointAdding.startPointRow = Math.Max(0, (PointAdding.Row - 3));
            PointAdding.endPointRow = Math.Min(6, (PointAdding.Row + 3));


            int counter = 0;
            for (int i = 0; PointAdding.startPointRow + i < PointAdding.endPointRow + 1; i++)
            {
                if (gameBoard.Board[PointAdding.startPointRow + i, PointAdding.Column] == PointAdding.CurrentPlayer)
                {
                    counter++;
                    if (counter == 4)
                    {
                        return true;
                    }

                }
                else
                {
                    counter = 0;
                }

            }

            return false;
        }
        public bool PerpendicularTest(gameBoardModel gameBoard, PointAddingModel PointAdding)
        {
            // this function chack's if the bord has four points Perpendicular.
            PointAdding.startPointColumn = Math.Max(0, (PointAdding.Row - 3));
            PointAdding.endPointColumn = Math.Min(5, (PointAdding.Row + 3));


            int counter = 0;
            for (int i = 0; PointAdding.startPointColumn + i < PointAdding.endPointColumn + 1; i++)
            {
                if (gameBoard.Board[PointAdding.Row, PointAdding.startPointColumn+i] == PointAdding.CurrentPlayer)
                {
                    counter++;
                    if (counter == 4)
                    {
                        return true;
                    }

                }
                else
                {
                    counter = 0;
                }

            }

            return false;
        }
        int ComparisonStart(PointAddingModel pointAdding)
        {
            //This function compares coordinates of the starting point, in order to return one uniform point.
            int rowDelta = Math.Abs(pointAdding.startPointRow - pointAdding.Row);

            int coluumnDelta = Math.Abs(pointAdding.startPointColumn - pointAdding.Column);
            int Delta = Math.Min(rowDelta, coluumnDelta);
            return Delta;
        }
        int ComparisonEnd(PointAddingModel pointAdding)
        {
            //This function compares coordinates of the ending point, in order to return one uniform point.
            int rowDelta = Math.Abs(pointAdding.endPointRow - pointAdding.Row);

            int coluumnDelta = Math.Abs(pointAdding.endPointColumn - pointAdding.Column);
            int Delta = Math.Min(rowDelta, coluumnDelta);
            return Delta;
        }

    }
}
