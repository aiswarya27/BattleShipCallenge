using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipChallenge
{
    /*Defining class for a horizontally aligned ship*/
   public class HorizontalShip : Ship
    {
        private List<int> rowsWitHit=new List<int>();

        public HorizontalShip(Position shipStartPosition, Position shipEndPosition)
            : base(shipStartPosition, shipEndPosition)//Call base constructor explicitly
        {
        }

        //Function that will check whether ship received a hit or not 
        public override bool isHit(Attack attackCordinates)
        {
            if (shipStartPosition.xCoordinate == attackCordinates.attackPosition.xCoordinate)
            {
                if (attackCordinates.attackPosition.yCoordinate >= shipStartPosition.yCoordinate && attackCordinates.attackPosition.yCoordinate <= shipEndPosition.yCoordinate)
                {                    
                    if (!rowsWitHit.Contains(attackCordinates.attackPosition.yCoordinate))
                        rowsWitHit.Add(attackCordinates.attackPosition.yCoordinate);
                    checkIfSink();
                    return  true;
                }
                else return false;
            }
            else return false;
        }

        //Function that will check whether the ship received hits equal to its size
        public override bool checkIfSink()
        {
            this.isSink= (rowsWitHit.Count == (shipEndPosition.xCoordinate - shipStartPosition.xCoordinate) + 1) ? true : false;
            return isSink;
                
        }
    }
}
