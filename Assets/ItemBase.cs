using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    [SerializeField] Sprite _itemImage;
    [SerializeField] int _itemID;
    [SerializeField]string _itemName;

    public Sprite ItemImage { get => _itemImage;}
    public int ItemID { get => _itemID; }
    public string ItemName { get => _itemName; }

    public void ItemDown(int id)
    {        for (int i = 0; i < Inventory.instance.ItemCount; i++)
        {
            ItemState item = Inventory.instance.ItemArray[i];
            if (item._itemID == id)
            {
                item._itemCount--;
                break;
            }
            if (item._itemCount <= 0)
            {
                item = new ItemState("なし", -1, 0, Inventory.instance.DefaultImage);
            }
        }
    }

    public abstract void Get();
    public abstract void Use();
}
