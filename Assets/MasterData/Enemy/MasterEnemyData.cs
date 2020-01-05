using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[Serializable]
public class MasterEnemyData : ScriptableObject
{
    public string Name;
    public int HP;

    public List<MasterSkillData> Skills;
}
