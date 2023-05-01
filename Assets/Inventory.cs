using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Linq;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject _inventoryPanel;
    [SerializeField, Tooltip("ÉCÉìÉxÉìÉgÉäÇÃé˚î[êî"), Range(0, 10)]int _storage;
    Cell[,] _itemData;
    int[] _itemArray;
    
    private int GetWidth
    {
        get
        {
            return _itemData.GetLength(0);
        }
    }
    private int GetHight
    {
        get
        {
            return _itemData.GetLength(1);
        }
    }

    private void Awake()
    {
        _itemData = new Cell[_storage, _storage];
        _itemArray = Enumerable.Repeat(-1, GetWidth * GetHight).ToArray();
    }

    public void SetItem()
    {
        for(int i = 0; i < GetWidth; i++)
        {
            var horizontalPanel = _inventoryPanel.transform.GetChild(i);
            for(int j = 0; j < GetHight; j ++)
            {
                if (_itemArray[j] == -1)
                {
                    Image itemImage = horizontalPanel.GetChild(j).GetComponent<Image>();
                    switch (_itemArray[j])
                    {
                        case 0:
                            itemImage.sprite = (Sprite)Resources.Load("Sword");
                            break; 
                        case 1:
                            itemImage.sprite = (Sprite)Resources.Load("Gun");
                            break;
                        case 2:
                            itemImage.sprite = (Sprite)Resources.Load("PowerUpItem");
                            break;
                        case 3:
                            itemImage.sprite = (Sprite)Resources.Load("RecoveryItem");
                            break;
                    }
                    break;
                }
            }
        }
    }

    public void GetItem(ItemData item)
    {
        for(int i = 0; i < GetWidth; i++)
        {
            for(int j = 0; j < GetHight; j++)
            {
                int setIndex = ToIndex(_itemData[i, j]);
                if (_itemArray[setIndex] == -1)
                {
                    _itemArray[setIndex] = item._category;
                }
            }
        }
    }

    public int ToIndex(Cell item)
    {
        return item.horizontal + GetWidth * item.vertical;
    }

    public Cell ToCell(int index)
    {
        return new Cell(index % GetWidth, index / GetWidth);
    }
}
