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
        public MasterEnemyData MasterData;
        public IEnumerable<Skill> Skills;

        public Enemy()
        {
        }

        protected override void OnStart()
        {
            Name = MasterData.name;
            MaxHP = MasterData.HP;
            HP = MaxHP;
            Skills = MasterData.Skills.Select(x => new Skill(x)).ToList();
        }
    }
}
