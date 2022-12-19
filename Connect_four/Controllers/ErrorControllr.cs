using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_four
{
    internal class ErrorControllr:ErrorClass
    {
     public ErrorModel errorModel(ErrorModel errorModel,gameBoardModel gameBoardModel,PointAddingModel pointAddingModel)
        {
            if (ChackIfRowValid(pointAddingModel) == false)
            {
                errorModel.Posible = false;
                errorModel.Message = " The row you have chosen is out of range,Please choose another line ";
                return errorModel;
            }
            if (ChackIfColumenFull(pointAddingModel, gameBoardModel) == false)
            {
                errorModel.Posible = false;
                errorModel.Message = " This row is full, Please choose another line";
                return errorModel;
            }
            
            errorModel.Posible = true;
            return errorModel;
        }
    }
}
