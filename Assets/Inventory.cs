using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject _inventoryPanel;
    [SerializeField, Tooltip("ƒCƒ“ƒxƒ“ƒgƒŠ‚Ìû”[”"), Range(0, 10)]int _storage;
    ItemIndex[,] _itemData;
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
        _itemData = new ItemIndex[_storage, _storage];
        _itemArray = new int[GetHight * GetWidth];
    }


    public void GetItem()
    {

    }

    void ToIndex()
    {

    }
}
