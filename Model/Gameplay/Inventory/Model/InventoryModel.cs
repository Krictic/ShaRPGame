using ShaRPG.View.GUI;
using ShaRPGame.Model.GameplayModels.Inventory.InventoryInterfaces;
using ShaRPGame.Model.GameplayModels.Items.ItemInterfaces;

namespace ShaRPGame.Model.GameplayModels.Inventory.Model
{
    internal class InventoryModel : IInventory
    {
        private IInventory inventory;
        private int maxCapacity;

        public InventoryModel(IInventory inventory, int maxCapacity)
        {
            this.inventory = inventory;
            this.maxCapacity = maxCapacity;
        }

        public void AddItem(IItem item)
        {
            if (inventory.GetItems().Count() >= maxCapacity)
            {
                Gui.Alert("The inventory is full!");
            }
            inventory.AddItem(item);
        }

        public void RemoveItem(IItem item)
        {
            inventory.RemoveItem(item);
        }

        public IEnumerable<IItem> GetItems()
        {
            return inventory.GetItems();
        }
    }
}
