using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*This program implements Battleship state-tracker for a single player
Created by: Aiswarya Rajendran
Created date:22 April 2021 
Version 1.0*/

namespace BattleShipChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalShips = 0;
            List<Ship> listShip=new List<Ship>();

            Board board = new Board(10,10);//Creating the board with 10*10 squares


            //Getting the coordinate and alignment details for battleship
            #region Creating ship
            Console.WriteLine("Enter number of ships to be placed");           
            totalShips = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < totalShips; i++)
            {
                Console.WriteLine("Enter the start co-ordinates of ships to be placed formatted as x y x1 y1  (x and y being the start position and x1 and y1 being the end position)"); //Fetching ship cordinates            
                int[] position = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), (item) => Convert.ToInt32(item));
                
                Console.WriteLine("Enter keyword 'h' for'horizontal' or 'v' for 'vertical' for ship placement");//Fetching alignment details
                string alignment = Console.ReadLine();
               
                if (alignment.Equals("h"))
                {
                    Ship ship = new HorizontalShip(new Position(position[0], position[1]), new Position(position[2], position[3]));
                    listShip.Add(ship);

                }
                else if (alignment.Equals("v"))
                {
                    Ship ship = new VerticalShip(new Position(position[0], position[1]), new Position(position[2], position[3]));
                    listShip.Add(ship);
                }

            }
            #endregion 

            #region Creating players and launch ship ,then attack board
            GamePlayer player1 = new GamePlayer(board);//Creating Player1
            player1.lanchShip(listShip);

            AttackPlayer player2 = new AttackPlayer(board);//Creating Player2

            /*Fetching atacks-starts*/
            int totalAttacks = 0;
            Console.WriteLine("Enter number of attacks to be placed");
            totalAttacks = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < totalAttacks; i++)
            {
                Console.WriteLine("Enter an attack with x and y co-ordinates");
                int[] attackPosition = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), (item) => Convert.ToInt32(item));

                Attack attack = new Attack(new Position(attackPosition[0], attackPosition[1]));
                if (player2.launchAttack(attack))//launch attack to board
                    Console.WriteLine("Attack was a hit");
                else
                    Console.WriteLine("Attack was a miss");
                if (player2.isOpponentPlayerLostGame())
                    Console.WriteLine("Player 1 lost game");
                else
                    Console.WriteLine("Player 1 did not lose");
            }
            Console.ReadLine();
            #endregion



        }
        
    }
}