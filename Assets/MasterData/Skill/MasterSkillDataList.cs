using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu]
public class MasterSkillDataList : ScriptableObject
{
    public MasterSkillData[] Items;

#if UNITY_EDITOR
    [ContextMenu("Update Set")]
    public void Create()
    {
        Items = AssetDatabase
            .FindAssets(string.Format("t:{0}", "MasterSkillData"))
            .Select(guid =>
            {
                string assetPath = AssetDatabase.GUIDToAssetPath(guid);
                return AssetDatabase.LoadAssetAtPath<MasterSkillData>(assetPath);
            })
            .ToArray();
    }
#endif
}
