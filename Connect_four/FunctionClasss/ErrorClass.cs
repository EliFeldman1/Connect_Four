using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_four
{
    internal class ErrorClass
    {
       public bool ChackIfColumenFull(PointAddingModel pointAddingModel, gameBoardModel gameBoard)
        {
            if (gameBoard.ColumnCounter[pointAddingModel.Row] > 6)
            {
                return false;
            }
            else
                return true;
        }
      public  bool ChackIfRowValid(PointAddingModel pointAddingModel)
        {
            if (pointAddingModel.Row > 6|| pointAddingModel.Row < 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
