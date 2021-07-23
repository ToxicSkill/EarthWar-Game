namespace EarthWarNsp
{
    class Division : TacticalUnit, IMilitary<Division>//inherits TacticalUnit and military interface in type of Division
    {
        //ID counter
        public static int instanceCounter = 0;

        /// <summary>
        /// Division constructor
        /// </summary>
        /// <param name="power"></param>
        /// <param name="friendly"></param>
        public Division(int power, int friendly)
        {
            //assign passed values to object properties
            Power = power;
            Friendly = friendly;

            //modifying passed values to the new class 
            Power = ComputePower(this);
            Friendly = ComputeFriendly(this);

            //assign iterated counter to ID of division
            ID = IterateCounter();
        }

        /// <summary>
        /// Function compute Friendly property for Division
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int ComputeFriendly(Division input)
        {
            return (int)(input.Friendly * 0.5);
        }

        /// <summary>
        /// Function compute Power property for Division
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int ComputePower(Division input)
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
