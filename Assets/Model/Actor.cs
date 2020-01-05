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
        HP = MaxHP;
        ST = MaxST;
    }

    public void Action(IBattler target)
    {
        target.HP--;
    }

    public override void Reaction(IBattler target)
    {
        target.HP--;
    }
}
