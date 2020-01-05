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
    public Skill Weapon;
    public Skill UseSkill { get; internal set; }

    public Actor(MasterActorData masterData)
    {
        _masterData = masterData;
        Name = _masterData.Name;
        MaxHP = _masterData.HP;
        HP = MaxHP;

        MaxST = _masterData.ST;
        ST = MaxST;

        Skills = _masterData.Skills.Select(x => new Skill(x)).ToList();
        Weapon = new Skill(_masterData.Weapon);
    }

    public void Action(IBattler target, IMessage message)
    {
        UseSkill.Use(this, target, message);
    }

    public override void Reaction(IBattler target, IMessage message)
    {
        Weapon.Use(this, target, message);
    }
}
