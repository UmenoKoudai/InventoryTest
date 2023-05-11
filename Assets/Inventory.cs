using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : InstanceSystem<Inventory>
{
    [SerializeField] GameObject _inventory;
    [SerializeField] Sprite _defaultImage;
    ItemState[] _itemArray;
    int _itemBoxCount;

    public ItemState[] ItemArray { get => _itemArray; }
    public Sprite DefaultImage { get => _defaultImage; }
    public int ItemCount { get => _itemBoxCount; }

    void Awake()
    {
        _itemBoxCount = _inventory.transform.childCount;
        _itemArray = Enumerable.Repeat(new ItemState("なし", -1, 0, _defaultImage), _itemBoxCount).ToArray();
    }
    public void SetItem()
    {
        for (int i = 0; i < _itemBoxCount; i++)
        {
            if (_itemArray[i]._itemID != -1)
            {
            }
        }
    }

    //public void GetItem()
    //{
    //    int item = UnityEngine.Random.Range(0, _itemImges.Length);
    //    for (int i = 0; i < _itemBoxCount; i++)
    //    {
    //        if (_itemArray[i] == -1)
    //        {
    //            _itemArray[i] = item;
    //            break;
    //        }
    //    }
    //}
}
