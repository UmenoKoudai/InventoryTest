using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : MonoBehaviour
{
    [SerializeField] Effect _effectType = Effect.Recovery;
    [SerializeField, Tooltip("どれくらい回復するか")] int _recoveryNum;
    [SerializeField, Tooltip("どれくらい攻撃力が上がるか")] int _powerUpNum;
    [SerializeField, Tooltip("どれくらい防御力を上げるか")] int _defenseUpNum;
    [SerializeField, Tooltip("どれくらい相手にダメージを与えるか")] int _damageNum;

    public int Recovery { get => _recoveryNum; set => _recoveryNum = value; }
    public int PowerUp { get => _powerUpNum; set => _powerUpNum = value; }
    public int DefenseUp { get => _defenseUpNum; set => _defenseUpNum = value; }
    public int Damage { get => _damageNum; set => _damageNum = value; }
    public Effect EffectType { get => _effectType; set => _effectType = value; }

    //enum毎に実行する関数を変化させる
    public void RecoveryEffect()　//HP回復
    {
        Debug.Log("体力回復");
    }

    public void PowerUpEffect()　//攻撃力アップ
    {
        Debug.Log("攻撃力アップ");
    }

    public void DefenseUpEffect()　//防御力アップ
    {
        Debug.Log("防御力アップ");
    }

    public void DamageEffect()　//ダメージを与える
    {
        Debug.Log("ダメージを与えた");
    }

    //アイテムの機能(関数)を切り替えるenum
    public enum Effect
    {
        Recovery, //回復の関数
        PowerUp,　//攻撃力アップの関数
        DefenseUp,　//防御力アップの関数
        Damage,　//ダメージを与える関数
    }
}
