using System;
namespace tpmodul4_1302220046;


class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();


        Console.WriteLine(kodePos.getKodePos(Kelurahan.Batununggal));
        Console.WriteLine(kodePos.getKodePos(Kelurahan.Kujangsari));
        Console.WriteLine(kodePos.getKodePos(Kelurahan.Kebonwaru));

        DoorMachine doorMachine = new DoorMachine();
        doorMachine.Run();

    }
}
