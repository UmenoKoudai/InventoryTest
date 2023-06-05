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
            effect.Recovery = EditorGUILayout.IntField("回復量", effect.Recovery);
        }
        if (effect.EffectType == ItemEffect.Effect.PowerUp)
        {
            effect.PowerUp = EditorGUILayout.IntField("攻撃力アップ量", effect.PowerUp);
        }
        if(effect.EffectType == ItemEffect.Effect.DefenseUp)
        {
            effect.DefenseUp = EditorGUILayout.IntField ("防御力アップ量", effect.DefenseUp);
        }
        if(effect.EffectType == ItemEffect.Effect.Damage)
        {
            effect.Damage = EditorGUILayout.IntField("与えるダメージ量", effect.Damage);
        }

        EditorUtility.SetDirty(effect);
    }
}
