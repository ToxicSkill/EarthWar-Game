namespace EarthWarNsp
{
    interface IMilitary<T>//object template
    {
        int ComputePower(T input); //a function that calculates the current power of the object

        int ComputeFriendly(T input);//a function that calculates the current friendly of the object

        int IterateCounter();//a function that increment counter
    }
}
