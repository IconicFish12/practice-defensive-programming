using practice_defensive_programming;
using System;

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo data = new SayaTubeVideo("halooo");

        data.increasePlayCount(10);

        data.printAllVideo();
    }
}
