using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Actor : Battler
{
    private MasterActorData _masterData;

    public int MaxST { get; set; } = 12;
    public int ST { get; set; }

    public IEnumerable<Skill> Skills;
    public Skill[] Weapon = new Skill[2];
    public Skill UseSkill { get; internal set; }

    public bool AllowSwitchWeapon => Weapon[1] != null;

    public Actor(MasterActorData masterData)
    {
        _masterData = masterData;
        Name = _masterData.Name;
        MaxHP = _masterData.HP;
        HP = MaxHP;

        MaxST = _masterData.ST;
        ST = MaxST;

        Skills = _masterData.Skills.Select(x => new Skill(x)).ToList();
        Weapon[0] = new Skill(_masterData.Weapon);
        Weapon[1] = new Skill(_masterData.SubWeapon);
    }

    public void Action(IBattler target, IMessage message)
    {
        UseSkill.Use(this, target, message);
    }

    public override void Reaction(IBattler target, IMessage message)
    {
        Weapon[0].Use(this, target, message);
    }

    public void SwitchWeapon()
    {
        var tmp = Weapon[0];
        Weapon[0] = Weapon[1];
        Weapon[1] = tmp;
    }
}
