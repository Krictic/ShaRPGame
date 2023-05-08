using ShaRPG.View.GUI;
using ShaRPGame.Model.GameplayModels.Inventory.InventoryInterfaces;
using ShaRPGame.Model.GameplayModels.Items.ItemInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
