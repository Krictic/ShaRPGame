using ShaRPGame.Model.GameplayModels.Items.ItemInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.GameplayModels.Inventory.InventoryInterfaces
{
    internal interface IInventory
    {
        void AddItem(IItem item);
        void RemoveItem(IItem item);
        IEnumerable<IItem> GetItems();
    }
}
