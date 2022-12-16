using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChackForFour chackForFour= new ChackForFour();
            gameBoardModel gameBoard = new gameBoardModel();
            PointAddingModel pointAddingModel= new PointAddingModel();
            pointAddingModel.CurrentPlayer = "Red";
            for (int i = 2; i < 6; i++)
            {
                gameBoard.Board[i, i] = pointAddingModel.CurrentPlayer;
            }
            pointAddingModel.CurrentPlayer = "Red";
            pointAddingModel.Colum = 5;
            pointAddingModel.Row = 5;
            bool Is = chackForFour.DiagonalRightUpTest(gameBoard, pointAddingModel);
        }
    }
}
