using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : InstanceSystem<Inventory>
{
    public class ItemData { public ItemState[] _itemArray; }

    [SerializeField] GameObject _inventory;　//表示させたいアイテムボックスのオブジェクト
    [SerializeField] Sprite _defaultImage;
    ItemState[] _itemArray;　//今獲得しているアイテムの情報を格納
    int _itemBoxCount;　
    ItemData _itemData;

    public ItemState[] ItemArray { get => _itemArray; }
    public Sprite DefaultImage { get => _defaultImage; }
    public int ItemCount { get => _itemBoxCount; }

    void Awake()
    {
        _itemBoxCount = _inventory.transform.childCount;
        if (_itemArray == null)
        {
            _itemArray = Enumerable.Repeat(new ItemState("なし", -1, 0, null, null), _itemBoxCount).ToArray(); //アイテム配列に何も入っていなかったら
        }
        SetItem();
    }
    public void SetItem()
    {
        //アイテムボックスの数だけループを回して取得しているアイテムをアイテムボックスに反映させる
        for (int i = 0; i < _itemBoxCount; i++)
        {
            //インベントリオブジェクトの直下のオブジェクトを１つずつ取得していく
            var viewItemParent = _inventory.transform.GetChild(i);
            //ItemButtonスクリプトがアタッチされているオブジェクトを取得
            var viewItem = viewItemParent.transform.GetChild(0).GetComponent<ItemButton>();
            //取得アイテムの配列を確認して-1(アイテムを持っていない)状態じゃ無かったらインベントリに反映させる
            if (_itemArray[i]._itemID != -1)
            {
                viewItem.SetItem = _itemArray[i];
            }
            else
            {
                viewItem.SetItem = new ItemState("", -1, 0, _defaultImage, null);
            }
        }
    }
}
