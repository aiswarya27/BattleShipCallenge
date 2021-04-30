using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Class for defining Board*/
namespace BattleShipChallenge
{
    public class Board
    {
        public List<Ship> listShip;
        public Position bottomLeftCordinates = new Position(0, 0);
        public Position topRightCordinates = new Position(0, 0);

        public  Board(int topRightXCordinates, int topRightYCordinates)
        {
            this.topRightCordinates=this.topRightCordinates.newCordinatesFor(topRightXCordinates,topRightYCordinates);
        }
       
        /*Function to add ship on the board*/
        public void addShipstoBoard(List<Ship> ships)
        {
            this.listShip = ships;
        }

        /*Function to recieve a hit on the board*/
        public bool recieveAttack(Attack attack)
        {
            bool flag = false;

            foreach (Ship ship in listShip)
            {
                if (ship.isHit(attack)) 
                {
                    flag = true;
                }
            }
            return flag;
        }

        /*Function to check whether all GamePlayer ships have sinked*/
        public bool isAllShipsSinked()
        {
            bool flag = false;
            flag = listShip.All(ship => ship.isSink == true);
            return flag;

        }
    }
}
