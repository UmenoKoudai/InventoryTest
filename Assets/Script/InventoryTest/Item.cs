using System;
using UnityEngine;

public class Item : ItemBase
{
    ItemEffect _effectScript;
    event Action _effect;

    private void Awake()
    {
        //選択しているenumによってActionに代入する関数を変える
        _effectScript = GetComponent<ItemEffect>();
        if (_effectScript.EffectType == ItemEffect.Effect.Recovery)
        {
            _effect += _effectScript.RecoveryEffect;
        }
        if (_effectScript.EffectType == ItemEffect.Effect.PowerUp)
        {
            _effect += _effectScript.PowerUpEffect;
        }
        if (_effectScript.EffectType == ItemEffect.Effect.DefenseUp)
        {
            _effect += _effectScript.DefenseUpEffect;
        }
        if (_effectScript.EffectType == ItemEffect.Effect.Damage)
        {
            _effect += _effectScript.DamageEffect;
        }
    }

    //アイテムに触れた時ゲットする
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Get();
    }

    //アイテムをゲットする関数
    public void Get()
    {
        //インベントリの数だけループを回す
        for (int i = 0; i < Inventory.instance.ItemCount; i++)
        {
            //取得アイテム配列のi番目を格納
            ItemState item = Inventory.instance.ItemArray[i];
            //アイテム配列を取得
            var ItemArray = Inventory.instance.ItemArray;
            //もしアイテムが何も登録されてなかったら
            if (item._itemID == -1)
            {
                //今セットしているアイテム情報をセットする
                ItemArray[i] = new ItemState(base.ItemName, base.ItemID, 1, base.ItemImage, _effect);
                //インベントリに反映させる
                Inventory.instance.SetItem();
                break;
            }
            //同じアイテムを持っていたらアイテムカウントを1つ上げる
            if (item._itemID == base.ItemID && item._itemCount < 99)
            {
                item._itemCount++;
                Inventory.instance.SetItem();
                break;
            }
        }
    }
}
