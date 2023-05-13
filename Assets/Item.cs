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
                ItemArrayTest[i] = new ItemState(base.ItemName, base.ItemID, 1, base.ItemImage);
                Inventory.instance.SetItem();
                Inventory.instance.Debuger();
                break;
            }
            if(item._itemID == base.ItemID)
            {
                item._itemCount++;
                Inventory.instance.SetItem();
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
