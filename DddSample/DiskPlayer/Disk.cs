using System;
using DddFramework;

namespace DddSample
{
    public class Disk : ValueObject<Disk>, ICloneable
    {
        public static Disk None = new Disk(Guid.Empty);
        public static Disk Disk1 = new Disk(new Guid("C60B5DA8-3A9E-447C-8EAD-D458049A1FB1"));
        public static Disk Disk2 = new Disk(new Guid("F710FB3F-DB94-4A0C-9107-AF7412E2011E"));

        public Guid Id { get; private set; }

        public Disk() {
            Id = Guid.NewGuid();
        }
        public Disk(Guid id) {
            Id = id;
        }

        protected override bool EqualsCore(Disk other) {
            return Id == other.Id;
        }
        protected override int GetHashCodeCore() {
            return Id.GetHashCode();
        }

        public object Clone() {
            return new Disk(Id);
        }
    }
}
