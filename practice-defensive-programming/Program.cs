using practice_defensive_programming;
using System;

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo data1 = new SayaTubeVideo("");
        SayaTubeVideo data2 = new SayaTubeVideo("bye");
        SayaTubeVideo data3 = new SayaTubeVideo("starlight");
        data1.increasePlayCount(10);
        data2.increasePlayCount(25_000_000);
        data3.increasePlayCount(4000);

        data1.printAllVideo();
        data2.printAllVideo();
        data3.printAllVideo();

    }
}
