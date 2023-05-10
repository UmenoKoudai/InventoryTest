using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : InstanceSystem<Inventory>
{
    [SerializeField] GameObject _inventory;
    [SerializeField] Sprite[] _itemImges;
    int[] _itemArray;
    int _itemBoxCount;


    public int ItemCount { get => _itemBoxCount; }

    void Awake()
    {
        _itemBoxCount = _inventory.transform.childCount;
        _itemArray = Enumerable.Repeat(-1, _itemBoxCount).ToArray();
    }
    public void SetItem()
    {
        for (int i = 0; i < _itemBoxCount; i++)
        {
            if (_itemArray[i] != -1)
            {
                var item = _inventory.transform.GetChild(i).gameObject.GetComponent<Image>();
                item.sprite = _itemImges[_itemArray[i]];
            }
        }
    }

    public void GetItem()
    {
        int item = UnityEngine.Random.Range(0, _itemImges.Length);
        for (int i = 0; i < _itemBoxCount; i++)
        {
            if (_itemArray[i] == -1)
            {
                _itemArray[i] = item;
                break;
            }
        }
    }
}
