using System;
using DddFramework;

namespace DddSample
{
    public class DiskPlayer : AggregateRoot
    {
        private DiskDrive _diskDrive { get; set; }

        public DiskPlayer() {
            _diskDrive = new DiskDrive();
        }

        public void InsertDisk(Disk disk) {
            Console.WriteLine($"Inserting disk: {disk.Id}");

            this._diskDrive.Accept(disk);
        }

        public Disk EjectDisk() {
            var ejectedDisk = this._diskDrive.Eject();

            if (ejectedDisk != Disk.None) {
                Console.WriteLine($"Ejected disk: {(ejectedDisk.Id)}");
            } else {
                Console.WriteLine($"Disk drive is Empty!");
            }

            return ejectedDisk;
        }

        public void Play() {
            if (_diskDrive._disk == Disk.None) {
                Console.WriteLine("Please insert a disk to play!");
                return;
            }

            Console.WriteLine($"Playing disk: {_diskDrive._disk.Id}");
        }
    }
}
