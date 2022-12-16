using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_four
{
    internal class ChackForFour
    {

        // Diagonal test;
        public bool DiagonalRightUpTest(gameBoardModel gameBoardModel, PointAddingModel PointAddingModel)
        {
            // this function chack's if the bord has four points Diagonally, and this when the right side is the bottom
            int startPointRow = Math.Max(0, (PointAddingModel.Row - 3));
            int endPointRow =Math.Min(6,(PointAddingModel.Row + 3));
            int startPointColumn =Math.Max(0,PointAddingModel.Colum-3);
            int endPointColumn = Math.Min(5, PointAddingModel.Colum + 3);
            int counter = 0;
            for (int i = 0; startPointRow+i< endPointRow || startPointColumn+i< endPointColumn; i++)
            {
                if (gameBoardModel.Board[startPointRow + i, startPointColumn + i] == PointAddingModel.CurrentPlayer)
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
        // Perpendicular test
        //  Horizontal test
    }
}
