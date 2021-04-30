using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Defining class for an Attack*/
namespace BattleShipChallenge
{
    public class Attack
    {
        public Position attackPosition;
        
        public  Attack(Position attackPosition)
        {
            this.attackPosition = attackPosition;
        }

    }
}
