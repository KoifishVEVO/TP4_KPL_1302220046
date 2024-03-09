using System;

namespace tpmodul4_1302220046;


    public class DoorMachine
    {
        enum States
        {
            Terkunci,
            Terbuka
        }

        string[] screen = { "Terkunci", "Terbuka" };
        States state = States.Terkunci;

        public void Run()
        {
            string command = "";

            while (command != "EXIT")
            {
                Console.WriteLine(screen[(int)state]);
                Console.Write("Enter command: ");
                command = Console.ReadLine();

                switch (state)
                {
                    case States.Terkunci:
                        if (command == "BukaPintu")
                        {
                            state = States.Terbuka;
                            Console.WriteLine("Pintu terbuka");
                        }
                        else if (command == "KunciPintu")
                        {
                            state = States.Terkunci;
                            Console.WriteLine("Pintu terkunci");
                        }
                        break;
                    case States.Terbuka:
                        if (command == "BukaPintu")
                        {
                            state = States.Terbuka;
                            Console.WriteLine("Pintu terbuka");
                        }
                        else if (command == "KunciPintu")
                        {
                            state = States.Terkunci;
                            Console.WriteLine("Pintu terkunci");
                        }
                        break;
                    default:
                        Console.WriteLine("Input salah");
                        break;
                }
            }
        }
    }
