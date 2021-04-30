using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Definig class for a GamePlayer (who places the ships on board) and an AttackPlayer (who launch an attack on board) */
namespace BattleShipChallenge
{
    //Defining class for GamePlayer
    public class GamePlayer
    {        
        Board gameBoard;
        public GamePlayer(Board board)
        {
            this.gameBoard = board;
        }

        //Function to place ship on board
        public void lanchShip(List<Ship> listShip)
        {
            gameBoard.addShipstoBoard(listShip);
        }
    }

    //Defining class for AttackPlayer
    public class AttackPlayer
    {        
        Board attackingboard;

        public AttackPlayer(Board board)
        {
            this.attackingboard = board;
        }

        //Function to launch an attack on board
        public bool launchAttack(Attack attack)
        {
           return this.attackingboard.recieveAttack(attack);
        }

        //Function to check whether all ships of the GamePlayer had sunk
        public bool isOpponentPlayerLostGame()
        {
           return this.attackingboard.isAllShipsSinked();
        }

    }
}
