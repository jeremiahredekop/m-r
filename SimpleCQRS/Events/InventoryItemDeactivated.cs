using System;
using System.Linq;

namespace SimpleCQRS.Events
{
    public class InventoryItemDeactivated : Event {
        public readonly Guid Id;

        public InventoryItemDeactivated(Guid id)
        {
            Id = id;
        }
    }
}