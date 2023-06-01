using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : ItemBase
{
    [SerializeField] ItemEffectState _effectType = ItemEffectState.Recovery;
    [SerializeField, Tooltip("どれくらい回復するか")] int _recoveryNum;
    [SerializeField, Tooltip("どれくらい攻撃力が上がるか")] int _powerUpNum;
    [SerializeField, Tooltip("どれくらい防御力を上げるか")] int _defenseUpNum;
    [SerializeField, Tooltip("どれくらい相手にダメージを与えるか")] int _damageNum;

    public ItemEffectState EffectType { get => _effectType; set => _effectType = value; }
    public int Recovery { get => _recoveryNum; set => _recoveryNum = value; }
    public int PowerUp { get => _powerUpNum; set => _powerUpNum = value; }
    public int DefenseUp { get => _defenseUpNum; set => _defenseUpNum = value; }
    public int Damage { get => _damageNum; set => _damageNum = value; }

    public override void Get()
    {
        throw new System.NotImplementedException();
    }

    public enum ItemEffectState
    {
        Recovery, //回復の関数
        PowerUp,　//攻撃力アップの関数
        DefenseUp,　//防御力アップの関数
        Damage,
    }
}
