using System;

namespace EarthWarNsp
{
    class Soldier : TacticalUnit,IMilitary<Soldier>//inherits TacticalUnit and military interface in type of Soldier
    {
        //creating new random object
        Random random = new Random();

        //New properties for Soldier
        public int Age { get; private set; }
        public double Height { get; private set; }
        public double Weight { get; private set; }

        //counter for ID
        public static int instanceCounter = 0;

        /// <summary>
        /// Soldier constructor
        /// </summary>
        public Soldier() {
            //Increment ID counter and assign it to ID
            ID = IterateCounter();
            //Choose friendly randomly form -10 to 20
            Friendly = random.Next(-10, 20);
            //Choose power randomly form 10 to 1000
            Power = random.Next(10, (int)1e3);
            //Choose Age randomly form 18 to 60
            Age = random.Next(18, 60);
            //Choose Height randomly form 1.6 to 2.1
            Height = (double)random.Next(160, 210)/100;
            //Choose Weight randomly form 65 to 120
            Weight = random.Next(65, 120);
        }

        /// <summary>
        /// Function compute Power property for Soldier
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int ComputePower(Soldier input)
        {
            return input.Power - input.Age * 2 + (int)(input.Weight * input.Height * 10);
        }

        /// <summary>
        /// Function increment counter by one
        /// </summary>
        /// <returns></returns>
        public int IterateCounter()
        {
            return ++instanceCounter;
        }

        /// <summary>
        /// Function compute Friendly property for Soldier
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int ComputeFriendly(Soldier input)
        {
            return (int)(input.Friendly * 1.2);
        }
    }
}
