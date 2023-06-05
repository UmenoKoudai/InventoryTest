using System;
using UnityEngine;
using static Item;

public abstract class ItemBase : MonoBehaviour
{
    [SerializeField] Sprite _itemImage;
    [SerializeField] int _itemID;
    [SerializeField]string _itemName;

    public Sprite ItemImage { get => _itemImage;}
    public int ItemID { get => _itemID; }
    public string ItemName { get => _itemName; }
}
