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
            item.Recovery = EditorGUILayout.IntField("回復量",item.Recovery);
        }
        if (item.EffectType == ItemEffect.ItemEffectState.PowerUp)
        {
            item.PowerUp = EditorGUILayout.IntField("攻撃力アップ量",item.PowerUp);
        }
        if(item.EffectType == ItemEffect.ItemEffectState.DefenseUp)
        {
            item.DefenseUp = EditorGUILayout.IntField ("防御力アップ量",item.DefenseUp);
        }
        if(item.EffectType == ItemEffect.ItemEffectState.Damage)
        {
            item.Damage = EditorGUILayout.IntField("与えるダメージ量",item.Damage);
        }

        EditorUtility.SetDirty(item);
    }
}
