using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize : MonoBehaviour
{
    public MasterActorData Actor1;
    public MasterActorData Actor2;
    public MasterEnemyData Enemy;

    // Start is called before the first frame update
    void Awake()
    {
        Repository.Set(new Global());
        Repository.Set(new Warehouse());

        var pt = new Party();
        pt.Actors[0] = new Actor(Actor1);
        pt.Actors[1] = new Actor(Actor2);
        Repository.Set(pt);

        Repository.Set(new Enemy(Enemy));
    }
}
