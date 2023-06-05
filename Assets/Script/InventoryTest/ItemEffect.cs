using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : MonoBehaviour
{
    [SerializeField] Effect _effectType = Effect.Recovery;
    [SerializeField, Tooltip("�ǂꂭ�炢�񕜂��邩")] int _recoveryNum;
    [SerializeField, Tooltip("�ǂꂭ�炢�U���͂��オ�邩")] int _powerUpNum;
    [SerializeField, Tooltip("�ǂꂭ�炢�h��͂��グ�邩")] int _defenseUpNum;
    [SerializeField, Tooltip("�ǂꂭ�炢����Ƀ_���[�W��^���邩")] int _damageNum;

    public int Recovery { get => _recoveryNum; set => _recoveryNum = value; }
    public int PowerUp { get => _powerUpNum; set => _powerUpNum = value; }
    public int DefenseUp { get => _defenseUpNum; set => _defenseUpNum = value; }
    public int Damage { get => _damageNum; set => _damageNum = value; }
    public Effect EffectType { get => _effectType; set => _effectType = value; }

    //enum���Ɏ��s����֐���ω�������
    public void RecoveryEffect()�@//HP��
    {
        Debug.Log("�̗͉�");
    }

    public void PowerUpEffect()�@//�U���̓A�b�v
    {
        Debug.Log("�U���̓A�b�v");
    }

    public void DefenseUpEffect()�@//�h��̓A�b�v
    {
        Debug.Log("�h��̓A�b�v");
    }

    public void DamageEffect()�@//�_���[�W��^����
    {
        Debug.Log("�_���[�W��^����");
    }

    //�A�C�e���̋@�\(�֐�)��؂�ւ���enum
    public enum Effect
    {
        Recovery, //�񕜂̊֐�
        PowerUp,�@//�U���̓A�b�v�̊֐�
        DefenseUp,�@//�h��̓A�b�v�̊֐�
        Damage,�@//�_���[�W��^����֐�
    }
}
