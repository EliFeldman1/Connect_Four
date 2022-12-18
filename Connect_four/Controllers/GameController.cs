using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_four
{
    internal class GameController : ChackForFour
    {
        bool ChackForFour(PointAddingModel pointAddingModel, gameBoardModel gameBoard)
        {

            if (DiagonalRightUpTest(gameBoard, pointAddingModel) == true)
            {
                return true;
            }
            if (DiagonalRightDownTest(gameBoard, pointAddingModel) == true)
            {
                return true;
            }
            if (HorizontalTest(gameBoard, pointAddingModel) == true)
            {
                return true;
            }
            if (PerpendicularTest(gameBoard, pointAddingModel) == true)
            {
                return true;
            }

            return false;
        }
      
        


    }
}
