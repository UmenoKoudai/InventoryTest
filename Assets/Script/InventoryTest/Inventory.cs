using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : InstanceSystem<Inventory>
{
    public class ItemData { public ItemState[] _itemArray; }

    [SerializeField] GameObject _inventory;
    ItemState[] _itemArray;
    int _itemBoxCount;
    ItemData _itemData = new ItemData();
    event Action _useItem;

    public ItemState[] ItemArray { get => _itemArray; }
    public int ItemCount { get => _itemBoxCount; }
    public Action UseItem { get => _useItem; set => _useItem = value; }

    void Awake()
    {
        _itemBoxCount = _inventory.transform.childCount;
        _itemArray = Enumerable.Repeat(new ItemState("なし", -1, 0, null, null), _itemBoxCount).ToArray();
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
            var _action = _itemArray[i];
            var viewItemParent = _inventory.transform.GetChild(i);
            var viewItem = viewItemParent.transform.GetChild(0).GetComponent<ItemButton>();
            if (_itemArray[i]._itemID != -1)
            {
                viewItem.SetItem = new ItemState(_itemArray[i]._itemName, _itemArray[i]._itemID, _itemArray[i]._itemCount, _itemArray[i]._itemImage, _useItem);
            }
        }
        //_itemData._itemArray = _itemArray;
        //_itemData.OnSave();
    }
}
