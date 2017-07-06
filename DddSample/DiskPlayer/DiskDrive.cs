using DddFramework;

namespace DddSample
{
    public class DiskDrive : Entity
    {
        public Disk _disk { get; private set; } = Disk.None;

        public Disk Eject() {
            var diskToReturn = (Disk)_disk.Clone();

            _disk = Disk.None;

            if (diskToReturn != Disk.None) {
                DomainEvents.Raise(new DiskEjectedEvent());
            }

            return diskToReturn;
        }

        public void Accept(Disk disk) {
            if (disk != null) {
                _disk = disk;

                DomainEvents.Raise(new DiskInsertedEvent(_disk));
            }
        }
    }
}
