using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Model
{
    public class Battler : MonoBehaviour, IBattler
    {
        public string Name { get; protected set; }
        public int MaxHP { get; set; } = 50;

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

        public void Start()
        {
            OnStart();
            HP = MaxHP;
        }

        protected virtual void OnStart()
        {

        }

        public Battler()
        {
        }

        public virtual void Reaction(IBattler enemy, IMessage message)
        {
        }
    }
}
