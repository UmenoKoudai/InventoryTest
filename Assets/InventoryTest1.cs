using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InventoryTest1 : MonoBehaviour
{
    [SerializeField, Tooltip("インベントリオブジェクト")] GameObject _inventoryPanel;
    //[SerializeField, Tooltip("インベントリの収納数"), Range(0, 10)]int _storage;
    [SerializeField] Sprite _axe;
    int _itemBoxCount;
    //[Tooltip("縦配列と横配列を収納数の数だけ保管できる配列")]
    //Cell[,] _itemData;
    [Tooltip("どの収納場所にが何のアイテムが格納されているか")]
    int[] _itemArray;
    
    ////_itemDataの要素数を取得(縦列)
    //private int GetWidth
    //{
    //    get
    //    {
    //        return _itemData.GetLength(0);
    //    }
    //}
    ////_itemDataの要素数を取得(横列)
    //private int GetHight
    //{
    //    get
    //    {
    //        return _itemData.GetLength(1);
    //    }
    //}

    private void Awake()
    {
        _itemBoxCount = _inventoryPanel.transform.childCount;
        //_itemData = new Cell[_storage, _storage];
        _itemArray = Enumerable.Repeat(-1, _itemBoxCount).ToArray();
    }

    //今の格納されているアイテムデータを反映させる
    public void SetItem()
    {
        //for(int i = 0; i < GetWidth; i++)
        //{
        //    var horizontalPanel = _inventoryPanel.transform.GetChild(i);
        //    for(int j = 0; j < GetHight; j ++)
        //    {
        //        if (_itemArray[j] != -1)
        //        {
        //            var itemImage = horizontalPanel.GetChild(j).gameObject.GetComponent<Image>();
        //            for (int n = 0; n < _itemArray.Length; n++)
        //            {
        //                switch (_itemArray[n])
        //                {
        //                    case 0:
        //                        //itemImage = (GameObject)Resources.Load("sword");
        //                        break;
        //                    case 1:
        //                        itemImage.sprite = _axe;
        //                        break;
        //                    case 2:
        //                        //itemImage = (GameObject)Resources.Load("apple");
        //                        break;
        //                    case 3:
        //                        //itemImage = (GameObject)Resources.Load("hp");
        //                        break;
        //                }
        //            }
        //        }
        //    }
        //}
    }

    //アイテムを取得したときにデータに登録する
    //public void GetItem(ItemData item)
    //{
    //    for(int i = 0; i < GetWidth; i++)
    //    {
    //        for(int j = 0; j < GetHight; j++)
    //        {
    //            int setIndex = ToIndex(_itemData[i, j]);
    //            if (_itemArray[setIndex] == -1)
    //            {
    //                _itemArray[setIndex] = item._category;
    //            }
    //        }
    //    }
    //}
    public void GetItem(int item)
    {
        //for(int i = 0; i < GetWidth * GetHight; i++)
        //{
        //    if (_itemArray[i] == -1)
        //    {
        //        _itemArray[i] = item;
        //        break;
        //    }
        //}
        //for (int i = 0; i < GetWidth; i++)
        //{
        //    for (int j = 0; j < GetHight; j++)
        //    {
        //        int setIndex = ToIndex(i, j);
        //        if (_itemArray[setIndex] == -1)
        //        {
        //            _itemArray[setIndex] = item;
        //            return;
        //        }
        //    }
        //}
    }

    //public int ToIndex(int x, int y)
    //{
    //    return x + GetWidth * y;
    //}

    //public Cell ToCell(int index)
    //{
    //    return new Cell(index % GetWidth, index / GetWidth);
    //}
}
