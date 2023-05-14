﻿using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : InstanceSystem<Inventory>
{
    public class ItemData { public ItemState[] _itemArray; }

    [SerializeField] GameObject _inventory;
    [SerializeField] Sprite _defaultImage;
    ItemState[] _itemArray;
    int _itemBoxCount;
    ItemData _itemData = new ItemData();

    public ItemState[] ItemArray { get => _itemArray; }
    public Sprite DefaultImage { get => _defaultImage; }
    public int ItemCount { get => _itemBoxCount; }

    void Awake()
    {
        _itemBoxCount = _inventory.transform.childCount;
        _itemArray = Enumerable.Repeat(new ItemState("なし", -1, 0, _defaultImage), _itemBoxCount).ToArray();
        //_itemData._itemArray = _itemArray;
        //_itemData = _itemData.OnLoad();
        //if (_itemData != null)
        //{
        //    _itemArray = _itemData._itemArray;
        //}
        SetItem();
    }
    public void Debuger()
    {
        foreach (var it in _itemArray)
        {
            Debug.Log(string.Format("ID = {0:#} NAME = {1:#} COUNT = {2:#}", it._itemID, it._itemName, it._itemCount));
        }
    }
    public void SetItem()
    {
        for (int i = 0; i < _itemBoxCount; i++)
        {
            var viewItemParent = _inventory.transform.GetChild(i);
            var viewItem = viewItemParent.transform.GetChild(0).GetComponent<ItemButton>();
            if (_itemArray[i]._itemID != -1)
            {
                viewItem.ItemID = _itemArray[i]._itemID;
                viewItem.ItemImage = _itemArray[i]._itemImage;
                viewItem.ItemCount = _itemArray[i]._itemCount;
            }
        }
        //_itemData._itemArray = _itemArray;
        //_itemData.OnSave();
    }
}
