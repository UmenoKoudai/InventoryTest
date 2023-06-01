using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : ItemBase
{
    [SerializeField] ItemEffectState _effectType = ItemEffectState.Recovery;
    [SerializeField, Tooltip("�ǂꂭ�炢�񕜂��邩")] int _recoveryNum;
    [SerializeField, Tooltip("�ǂꂭ�炢�U���͂��オ�邩")] int _powerUpNum;
    [SerializeField, Tooltip("�ǂꂭ�炢�h��͂��グ�邩")] int _defenseUpNum;
    [SerializeField, Tooltip("�ǂꂭ�炢����Ƀ_���[�W��^���邩")] int _damageNum;

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
        Recovery, //�񕜂̊֐�
        PowerUp,�@//�U���̓A�b�v�̊֐�
        DefenseUp,�@//�h��̓A�b�v�̊֐�
        Damage,
    }
}
