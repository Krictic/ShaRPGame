using ShaRPGame.Model.GameplayModels.Items.ItemInterfaces;

namespace ShaRPGame.Model.GameplayModels.Inventory.InventoryInterfaces
{
    internal interface IInventory
    {
        void AddItem(IItem item);
        void RemoveItem(IItem item);
        IEnumerable<IItem> GetItems();
    }
}
