using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Defining abstract class for creating ships*/
namespace BattleShipChallenge
{
    public abstract class  Ship
    {
        public Position shipStartPosition;
        protected Position shipEndPosition;
        protected int hitCount;
        public bool isSink;

        public Ship(Position shipStartPosition, Position shipEndPosition)
        {
            this.shipStartPosition=shipStartPosition;
            this.shipEndPosition=shipEndPosition;

        }

        public abstract bool isHit(Attack attackCordinates);
        public abstract bool checkIfSink();
            
        }

       

    


    }
    

