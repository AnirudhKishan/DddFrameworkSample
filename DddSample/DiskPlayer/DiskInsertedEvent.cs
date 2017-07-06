using DddFramework;

namespace DddSample
{
    public class DiskInsertedEvent : IDomainEvent
    {
        public Disk Disk { get; private set; }

        public DiskInsertedEvent(Disk disk) {
            Disk = disk;
        }
    }
}
