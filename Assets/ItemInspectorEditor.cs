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
        item.EffectType = (ItemEffect.ItemEffectState)EditorGUILayout.EnumPopup(item.EffectType);
        if (item.EffectType == ItemEffect.ItemEffectState.Recovery)
        {
            item.Recovery = EditorGUILayout.IntField("�񕜗�",item.Recovery);
        }
        if (item.EffectType == ItemEffect.ItemEffectState.PowerUp)
        {
            item.PowerUp = EditorGUILayout.IntField("�U���̓A�b�v��",item.PowerUp);
        }
        if(item.EffectType == ItemEffect.ItemEffectState.DefenseUp)
        {
            item.DefenseUp = EditorGUILayout.IntField ("�h��̓A�b�v��",item.DefenseUp);
        }
        if(item.EffectType == ItemEffect.ItemEffectState.Damage)
        {
            item.Damage = EditorGUILayout.IntField("�^����_���[�W��",item.Damage);
        }

        EditorUtility.SetDirty(item);
    }
}
