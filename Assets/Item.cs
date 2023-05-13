using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ItemBase
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Get();
    }
    public void GetButton()
    {
        Get();
    }
    public override void Get()
    {
        for (int i = 0; i < Inventory.instance.ItemCount; i++)
        {
            ItemState item = Inventory.instance.ItemArray[i];
            var ItemArrayTest = Inventory.instance.ItemArray;
            if (item._itemID == -1)
            {
                item._itemID = base.ItemID;
                item._itemImage = base.ItemImage;
                item._itemName = base.ItemName;
                item._itemCount = 1;
                Debug.Log(string.Format("ID = {0:#} NAME = {1:#} COUNT = {2:#}", item._itemID, item._itemName, item._itemCount));
                foreach (var it in ItemArrayTest)
                {
                    Debug.Log(string.Format("ID = {0:#} NAME = {1:#} COUNT = {2:#}", it._itemID, it._itemName, it._itemCount));
                }
                break;
            }
            if(item._itemID == base.ItemID)
            {
                item._itemCount++;
                break;
            }
            foreach(var it in ItemArrayTest)
            {
                Debug.Log(string.Format("ID = {0:N} NAME = {1:G} COUNT = {2:N}", it._itemID, it._itemName, it._itemCount));
            }
        }
    }

    public override void Use()
    {
        //アイテムの処理を書く
        base.ItemDown(base.ItemID);
    }
}
