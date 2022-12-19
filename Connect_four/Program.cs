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
            
            gameBoardModel gameBoard = new gameBoardModel();
            PointAddingModel pointAddingModel = new PointAddingModel();
            ErrorControllr errorControllr= new ErrorControllr();
            GameController gameController = new GameController();
            ErrorModel errorModel = new ErrorModel();
            bool Victory = false;

            while (!Victory)
            {
                Console.WriteLine(" Which player is playing now? Insert color ");
                pointAddingModel.CurrentPlayer = Console.ReadLine();
                Console.WriteLine(" Which row would you like to put your color in?");
                pointAddingModel.Row = Convert.ToInt32(Console.ReadLine());
                // error model chacks for error in the input
                errorModel = errorControllr.errorModel(errorModel, gameBoard, pointAddingModel);
                if (!errorModel.Posible)
                {
                    Console.WriteLine(errorModel.Message);

                }
                else
                {
                    
                    gameBoard.Board[pointAddingModel.Row, gameBoard.ColumnCounter[pointAddingModel.Row]] = pointAddingModel.CurrentPlayer;
                    pointAddingModel.Column = gameBoard.ColumnCounter[pointAddingModel.Row];
                    Victory = gameController.ChackForFour(pointAddingModel, gameBoard);
                    gameBoard.ColumnCounter[pointAddingModel.Row]++;
                    if (Victory == true)
                    {
                        Console.WriteLine(" Congratulations " + pointAddingModel.CurrentPlayer + "! you won");
                        Console.Read();
                    }
                }
            }
            
        }
    }
}
