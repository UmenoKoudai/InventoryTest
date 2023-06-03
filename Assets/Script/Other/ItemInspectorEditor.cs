using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ItemEffect))]
public class ItemInspectorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        ItemEffect item = target as ItemEffect;
        item.EffectType = (ItemEffect.ItemEffect)EditorGUILayout.EnumPopup(item.EffectType);
        if (item.EffectType == ItemEffect.ItemEffect.Recovery)
        {
            item.Recovery = EditorGUILayout.IntField("�񕜗�",item.Recovery);
        }
        if (item.EffectType == ItemEffect.ItemEffect.PowerUp)
        {
            item.PowerUp = EditorGUILayout.IntField("�U���̓A�b�v��",item.PowerUp);
        }
        if(item.EffectType == ItemEffect.ItemEffect.DefenseUp)
        {
            item.DefenseUp = EditorGUILayout.IntField ("�h��̓A�b�v��",item.DefenseUp);
        }
        if(item.EffectType == ItemEffect.ItemEffect.Damage)
        {
            item.Damage = EditorGUILayout.IntField("�^����_���[�W��",item.Damage);
        }

        EditorUtility.SetDirty(item);
    }
}
