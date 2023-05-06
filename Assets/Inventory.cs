using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject _inventory;
    [SerializeField] Sprite _axe;
    int[] _itemArray;
    int _itemBoxCount;
    // Start is called before the first frame update
    void Start()
    {
        _itemBoxCount = _inventory.transform.childCount;
        _itemArray = Enumerable.Repeat(-1, _itemBoxCount).ToArray();
    }
    public void SetItem(int item)
    {
        for(int i = 0; i < _itemBoxCount; i++)
        {
            if (_itemArray[i] == -1)
            {
                _itemArray[i] = item;
            }
            break;
        }
    }
    public void GetItem()
    {
        for(int i = 0; i < _itemBoxCount; i++)
        {
            if (_itemArray[i] != -1)
            {
                var item = _inventory.transform.GetChild(i).gameObject.GetComponent<Image>();
                switch(_itemArray[i])
                {
                    case 0:
                        break;
                    case 1:
                        item.sprite = _axe;
                        //item = (GameObject)Resources.Load("axe");
                        break;
                }
                break;
            }
        }
    }
}
