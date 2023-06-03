using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ItemBase
{
    event Action _effect;
    private void Awake()
    {
        if (base.Effect == ItemEffect.Recovery)
        {
            _effect += RecoveryEffect;
        }
        if(base.Effect == ItemEffect.PowerUp)
        {
            _effect += PowerUpEffect;
        }
        if (base.Effect == ItemEffect.DefenseUp)
        {
            _effect += DefenseUpEffect;
        }
        if (base.Effect == ItemEffect.Damage)
        {
            _effect += DamageEffect;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Get();
    }
    public void GetButton()
    {
        Get();
    }
    public void Get()
    {
        for (int i = 0; i < Inventory.instance.ItemCount; i++)
        {
            ItemState item = Inventory.instance.ItemArray[i];
            var ItemArrayTest = Inventory.instance.ItemArray;
            if (item._itemID == -1)
            {
                ItemArrayTest[i] = new ItemState(base.ItemName, base.ItemID, 1, base.ItemImage, _effect);
                Inventory.instance.SetItem();
                Inventory.instance.Debuger();
                break;
            }
            if (item._itemID == base.ItemID)
            {
                item._itemCount++;
                Inventory.instance.SetItem();
                break;
            }
        }
    }
    public void RecoveryEffect()
    {
        Debug.Log("体力回復");
    }

    public void PowerUpEffect()
    {
        Debug.Log("攻撃力アップ");
    }

    public void DefenseUpEffect()
    {
        Debug.Log("防御力アップ");
    }

    public void DamageEffect()
    {
        Debug.Log("ダメージを与えた");
    }
}
