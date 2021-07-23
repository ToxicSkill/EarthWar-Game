using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthWarNsp
{
    class Platoon : TacticalUnit, IMilitary<Platoon>//inherits TacticalUnit and military interface in type of Platoon
    {
        //counter for ID
        public static int instanceCounter = 0;

        /// <summary>
        /// Platoon constructor
        /// </summary>
        /// <param name="power"></param>
        /// <param name="friendly"></param>
        public Platoon(int power, int friendly)
        {
            //assign passed values to object properties
            Power = power;
            Friendly = friendly;

            //assign iterated counter to ID of division
            ID = IterateCounter();
        }

        /// <summary>
        /// Function compute Friendly property for Platoon
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int ComputeFriendly(Platoon input)
        {
            return (int)(input.Friendly * 1.5);
        }

        /// <summary>
        /// Function compute Power property for Platoon
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int ComputePower(Platoon input)
        {
            return input.Power * 2;
        }

        /// <summary>
        /// Function increment counter by one
        /// </summary>
        /// <returns></returns>
        public int IterateCounter()
        {
            return ++instanceCounter;
        }
    }
}
