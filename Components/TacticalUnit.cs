namespace EarthWarNsp
{
    abstract class TacticalUnit
    {
        /// <summary>
        /// An abstract class that holds power, friendly and ID property
        /// </summary>
        public int Power { get;  set; }
        public int Friendly { get;  set; }
        public int ID { get;  set; }
    }
}
