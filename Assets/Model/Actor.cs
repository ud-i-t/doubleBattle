using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Actor : Battler
{
    public MasterActorData MasterData;

    public int MaxST { get; set; } = 12;
    public int ST { get; set; }

    public IEnumerable<Skill> Skills;

    protected override void OnStart()
    {
        Name = MasterData.Name;
        MaxHP = MasterData.HP;
        ST = MaxST;

        Skills = MasterData.Skills.Select(x => new Skill(x));
    }

    public override void Reaction(IBattler target, IMessage message)
    {
        Skills.First().Use(this, target, message);
    }
}
