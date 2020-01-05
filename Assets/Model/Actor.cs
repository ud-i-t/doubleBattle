using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : Battler
{
    public MasterActorData MasterData;

    public int MaxST { get; set; } = 12;
    public int ST { get; set; }

    protected override void OnStart()
    {
        Name = MasterData.Name;
        MaxHP = MasterData.HP;
        ST = MaxST;
    }

    public void Action(IBattler target, IMessage message)
    {
        new Skill().Use(this, target, message);
    }

    public override void Reaction(IBattler target, IMessage message)
    {
        message.Message = $"{Name}の反撃！{target.Name}に{1}のダメージ";
        target.HP--;
    }
}
