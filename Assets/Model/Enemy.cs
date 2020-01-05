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
        private MasterEnemyData _masterData;
        public IEnumerable<Skill> Skills;

        public Enemy(MasterEnemyData masterData)
        {
            _masterData = masterData;
            Name = _masterData.name;
            MaxHP = _masterData.HP;
            HP = MaxHP;
            Skills = _masterData.Skills.Select(x => new Skill(x)).ToList();
        }
    }
}
