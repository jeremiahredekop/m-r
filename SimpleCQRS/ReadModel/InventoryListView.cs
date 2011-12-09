using System.Linq;
using SimpleCQRS.Bus;
using SimpleCQRS.Events;

namespace SimpleCQRS.ReadModel
{
    public class InventoryListView : IHandles<InventoryItemCreated>, IHandles<InventoryItemRenamed>, IHandles<InventoryItemDeactivated>
    {
        public void Handle(InventoryItemCreated message)
        {
            BullShitDatabase.list.Add(new InventoryItemListDto(message.Id, message.Name));
        }

        public void Handle(InventoryItemRenamed message)
        {
            var item = BullShitDatabase.list.Find(x => x.Id == message.Id);
            item.Name = message.NewName;
        }

        public void Handle(InventoryItemDeactivated message)
        {
            BullShitDatabase.list.RemoveAll(x => x.Id == message.Id);
        }
    }
}