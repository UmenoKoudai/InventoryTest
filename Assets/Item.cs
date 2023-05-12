using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ItemDataBase
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
            if (item._itemID == -1)
            {
                item._itemID = base.ItemID;
                item._itemImage = base.ItemImage;
                item._itemName = base.ItemName;
                item._itemCount = 1;
                break;
            }
            if(item._itemID == base.ItemID)
            {
                item._itemCount++;
                break;
            }
        }
    }

    public override void Use()
    {
        //アイテムの処理を書く
        base.ItemDown(base.ItemID);
    }
}
