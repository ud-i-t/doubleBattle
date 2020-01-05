using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : Battler
{
    public int MaxST { get; set; } = 12;
    public int ST { get; set; }

    public Actor()
    {
        Name = "アクター";
        HP = MaxHP;
        ST = MaxST;
    }

    public void Action(IBattler target, IMessage message)
    {
        new Skill().Use(this, target, message);
    }

    public override void Reaction(IBattler target, IMessage message)
    {
        message.Message = $"{Name}の反撃";
        target.HP--;
    }
}
