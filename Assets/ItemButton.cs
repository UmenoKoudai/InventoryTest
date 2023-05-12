using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    Sprite _itemImage;
    int _itemID = -1;
    string _itemName = "‚È‚µ";
    int _itemCount = 0;

    public Sprite ItemImage { get => _itemImage; set => _itemImage = value; } 
    public int ItemID { get => _itemID; set => _itemID = value; }
    public int ItemCount { get => _itemCount; set => _itemCount = value; }

    void Update()
    {
        if(_itemID != -1)
        {
            GetComponent<Image>().sprite = _itemImage;
            GetComponentInChildren<Text>().text = _itemCount.ToString();
        }
    }
}
