using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Model
{
    public class Party
    {
        public Actor[] Actors = new Actor[2];

        public bool IsDead => Actors.Count(x => x.HP <= 0) > 0;

        public void Switch()
        {
            var model = Actors[0];
            Actors[0] = Actors[1];
            Actors[1] = model;
        }
    }
}
