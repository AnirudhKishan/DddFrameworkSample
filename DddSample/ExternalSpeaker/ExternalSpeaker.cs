using System;
using DddFramework;

namespace DddSample
{
    public class ExternalSpeaker : AggregateRoot
    {
        public ExternalSpeaker() {
            DomainEvents.Register<DiskInsertedEvent>((e) => { TurnOn(); });
            DomainEvents.Register<DiskEjectedEvent>((e) => { TurnOff(); });
        }

        public void TurnOn() {
            Console.WriteLine("External Speaker turned on.");
        }

        public void TurnOff() {
            Console.WriteLine("External Speaker turned off.");
        }
    }
}
