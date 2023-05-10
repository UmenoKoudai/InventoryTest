using UnityEngine;

public abstract class ItemDataBase : ScriptableObject
{
    ItemState[] _itemArray = new ItemState[Inventory.instance.ItemCount];
    public ItemState[] ItemArray { get => _itemArray; set => _itemArray = value; }

    public abstract void Get();
    public abstract void Use();
}
