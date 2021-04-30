using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Defining class to setup coordinates for board position*/
namespace BattleShipChallenge
{
    public class Position
    {
        public int xCoordinate;
        public int yCoordinate;
        public Position(int xCoordinate, int yCoordinate)
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
        }

        public Position newCordinatesFor(int newXCordinate, int newYCordinate)
        {
            return new Position(newXCordinate, newYCordinate);
        } 

    }
}
