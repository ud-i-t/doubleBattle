using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Model
{
    public class Enemy : MonoBehaviour, IBattler
    {
        public int MaxHP { get; set; } = 20;

        private int _hp;
        public int HP
        {
            get { return _hp; }
            set
            {
                _hp = value;
                if (_hp < 0) _hp = 0;
                if (_hp > MaxHP) _hp = MaxHP;
            }
        }

        public void Action(IBattler target)
        {
            target.HP--;
        }

        public void Reaction(IBattler target)
        {

        }
    }
}
