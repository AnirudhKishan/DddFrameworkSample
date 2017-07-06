using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DddSample
{
    class Program
    {
        static void Main(string[] args) {
            var player = new DiskPlayer();

            var externalSpeaker = new ExternalSpeaker();

            while(true) {
                var toExit = false;

                PrintCommandPrompt();
                var cmd = int.Parse(Console.ReadLine());

                switch(cmd) {
                    case 1:
                        player.InsertDisk(Disk.Disk1);
                        break;
                    case 2:
                        player.InsertDisk(Disk.Disk2);
                        break;
                    case 3:
                        player.Play();
                        break;
                    case 4:
                        player.EjectDisk();
                        break;
                    case 5:
                        toExit = true;
                        break;
                    default:
                        Console.WriteLine("[ERROR] Unknown Command!");
                        break;
                }

                Console.WriteLine("\n\n");

                if (toExit) {
                    break;
                }
            }
        }

        private static void PrintCommandPrompt() {
            Console.WriteLine("1. Insert Disk 1");
            Console.WriteLine("2. Insert Disk 2");
            Console.WriteLine("3. Play");
            Console.WriteLine("4. Eject Disk");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter Command: ");
        }
    }
}
