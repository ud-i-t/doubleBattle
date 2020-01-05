using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Model
{
    public class Enemy : Battler
    {
        public Enemy()
        {
            Name = "エネミー";
            MaxHP = 20;
            HP = MaxHP;
        }

        public void Action(IBattler target, IMessage message)
        {
            new Skill().Use(this, target, message);
        }
    }
}
