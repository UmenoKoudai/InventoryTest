using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject _inventory;
    [SerializeField] Sprite[] _itemImges;
    int[] _itemArray;
    int _itemBoxCount;
    // Start is called before the first frame update
    void Start()
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
                switch (_itemArray[i])
                {
                    case 0:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 1:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 2:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 3:
                        item.sprite = _itemImges[_itemArray[i]];
                        break; 
                    case 4:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 5:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 6:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 7:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 8:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 9:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 10:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 11:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 12:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 13:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 14:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 15:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 16:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 17:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 18:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 19:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 20:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 21:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 22:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 23:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 24:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                    case 25:
                        item.sprite = _itemImges[_itemArray[i]];
                        break;
                }
            }
        }
    }
    public void GetItem()
    {
        int item = Random.Range(0, _itemImges.Length);
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
