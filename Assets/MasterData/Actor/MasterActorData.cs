using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[Serializable]
public class MasterActorData : ScriptableObject
{
    public string Name;
    public int HP;
    public int ST;

    public List<MasterSkillData> Skills;
    public MasterSkillData Weapon;
    public MasterSkillData SubWeapon;
}
