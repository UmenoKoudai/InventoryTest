using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField, Tooltip("インベントリオブジェクト")] GameObject _inventoryPanel;
    [SerializeField, Tooltip("インベントリの収納数"), Range(0, 10)]int _storage;
    [Tooltip("縦配列と横配列を収納数の数だけ保管できる配列")]
    Cell[,] _itemData;
    [Tooltip("どの収納場所にが何のアイテムが格納されているか")]
    int[] _itemArray;
    
    //_itemDataの要素数を取得(縦列)
    private int GetWidth
    {
        get
        {
            return _itemData.GetLength(0);
        }
    }
    //_itemDataの要素数を取得(横列)
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

    //今の格納されているアイテムデータを反映させる
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
                    return;
                }
            }
        }
    }

    //アイテムを取得したときにデータに登録する
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
