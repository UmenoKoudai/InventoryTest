using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    ItemState _setItem = new ItemState("", -1, 0, null, null);
    public ItemState SetItem { get => _setItem; set => _setItem = value; }

    void Update()
    {
        if(_setItem._itemID != -1)
        {
            GetComponent<Image>().sprite = _setItem._itemImage;
            GetComponentInChildren<Text>().text = _setItem._itemCount.ToString();
        }
    }
}
