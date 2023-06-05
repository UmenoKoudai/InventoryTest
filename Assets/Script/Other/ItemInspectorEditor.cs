using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ItemEffect))]
public class ItemInspectorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        ItemEffect effect = target as ItemEffect;
        effect.EffectType = (ItemEffect.Effect)EditorGUILayout.EnumPopup(effect.EffectType);
        if (effect.EffectType == ItemEffect.Effect.Recovery)
        {
            effect.Recovery = EditorGUILayout.IntField("�񕜗�", effect.Recovery);
        }
        if (effect.EffectType == ItemEffect.Effect.PowerUp)
        {
            effect.PowerUp = EditorGUILayout.IntField("�U���̓A�b�v��", effect.PowerUp);
        }
        if(effect.EffectType == ItemEffect.Effect.DefenseUp)
        {
            effect.DefenseUp = EditorGUILayout.IntField ("�h��̓A�b�v��", effect.DefenseUp);
        }
        if(effect.EffectType == ItemEffect.Effect.Damage)
        {
            effect.Damage = EditorGUILayout.IntField("�^����_���[�W��", effect.Damage);
        }

        EditorUtility.SetDirty(effect);
    }
}
