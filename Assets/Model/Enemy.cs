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
            MaxHP = 20;
            HP = MaxHP;
        }

        public void Action(IBattler target)
        {
            target.HP--;
        }
    }
}
