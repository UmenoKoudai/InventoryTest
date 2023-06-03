using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : ItemBase
{
    [SerializeField] ItemEffect _effectType = ItemEffect.Recovery;
    [SerializeField, Tooltip("‚Ç‚ê‚­‚ç‚¢‰ñ•œ‚·‚é‚©")] int _recoveryNum;
    [SerializeField, Tooltip("‚Ç‚ê‚­‚ç‚¢UŒ‚—Í‚ªã‚ª‚é‚©")] int _powerUpNum;
    [SerializeField, Tooltip("‚Ç‚ê‚­‚ç‚¢–hŒä—Í‚ðã‚°‚é‚©")] int _defenseUpNum;
    [SerializeField, Tooltip("‚Ç‚ê‚­‚ç‚¢‘ŠŽè‚Éƒ_ƒ[ƒW‚ð—^‚¦‚é‚©")] int _damageNum;

    public ItemEffect EffectType { get => _effectType; set => _effectType = value; }
    public int Recovery { get => _recoveryNum; set => _recoveryNum = value; }
    public int PowerUp { get => _powerUpNum; set => _powerUpNum = value; }
    public int DefenseUp { get => _defenseUpNum; set => _defenseUpNum = value; }
    public int Damage { get => _damageNum; set => _damageNum = value; }
}
