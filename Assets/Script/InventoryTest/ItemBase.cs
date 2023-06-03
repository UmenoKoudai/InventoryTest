using System;
using UnityEngine;
using static Item;

public abstract class ItemBase : MonoBehaviour
{
    [SerializeField] Sprite _itemImage;
    [SerializeField] int _itemID;
    [SerializeField]string _itemName;
    event Action _itemUse;
    ItemEffect _effect;

    public Sprite ItemImage { get => _itemImage;}
    public int ItemID { get => _itemID; }
    public string ItemName { get => _itemName; }
    public Action ItemUse { get => _itemUse; set => _itemUse = value; }
    public ItemEffect Effect { get => _effect; set => _effect = value; }

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
                item = new ItemState("なし", -1, 0, null, null);
            }
        }
    }
    public enum ItemEffect
    {
        Recovery, //回復の関数
        PowerUp,　//攻撃力アップの関数
        DefenseUp,　//防御力アップの関数
        Damage,
    }
}
