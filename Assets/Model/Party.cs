using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Model
{
    public class Party : MonoBehaviour
    {
        public ActorViewModel[] actors = new ActorViewModel[2];

        public void Switch()
        {
            var model = actors[0].Model;
            actors[0].Model = actors[1].Model;
            actors[1].Model = model;
        }
    }
}
