using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_four
{
    internal class ErrorControllr:ErrorClass
    {
      ErrorModel errorModel(ErrorModel errorModel,gameBoardModel gameBoardModel,PointAddingModel pointAddingModel)
        {
            if (ChackIfColumenFull(pointAddingModel, gameBoardModel) == false)
            {
                errorModel.Posible = false;
                errorModel.Message = " This row is full";
                return errorModel;
            }
            if (ChackIfRowValid(pointAddingModel) == false)
            {
                errorModel.Posible = false;
                errorModel.Message = " The row you have chosen is out of range ";
                return errorModel;
            }
            errorModel.Posible = true;
            return errorModel;
        }
    }
}
