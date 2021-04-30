using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipChallenge
{
    /*Defining class for a vertically aligned ship*/
    public class VerticalShip:Ship
    {
        private List<int> columnsWitHit=new List<int>();

        public VerticalShip(Position shipStartPosition, Position shipEndPosition)
            : base(shipStartPosition, shipEndPosition)//Call base constructor explicitly
        {
            

        }

        //Function that will check whether ship received a hit or not 
        public override bool isHit(Attack attack)
        {
            if (shipStartPosition.yCoordinate == attack.attackPosition.yCoordinate)
            {
                if (attack.attackPosition.xCoordinate >= shipStartPosition.xCoordinate && attack.attackPosition.xCoordinate <= shipEndPosition.xCoordinate)
                {                   
                    if (!columnsWitHit.Contains(attack.attackPosition.xCoordinate))
                        columnsWitHit.Add(attack.attackPosition.xCoordinate);
                    checkIfSink();
                    return true;
                }
                else return false;
            }
            else return false;
        }

        //Function that will check whether the ship received hits equal to its size
        public override bool checkIfSink()
        {
            this.isSink=(columnsWitHit.Count == (shipEndPosition.yCoordinate - shipStartPosition.yCoordinate) + 1) ? true : false;
            return isSink;

        }
    }
}
