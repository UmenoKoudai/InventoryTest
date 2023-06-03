using System;
using UnityEngine;

public class ItemState
{
    public string _itemName; //各アイテムの名前
    public int _itemID;　//各アイテムのID
    public int _itemCount; //所持しているアイテムの数
    public Sprite _itemImage;　//貼り付けるアイテムのイメージ
    public event Action _action;
    public ItemState(string itemName, int itemID, int itemCount, Sprite itemImage, Action action)
    {
        _itemName = itemName;
        _itemID = itemID;
        _itemCount = itemCount;
        _itemImage = itemImage;
        _action = action;
    }
}
