using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Initialize : MonoBehaviour
{
    public MasterActorData Actor1;
    public MasterActorData Actor2;
    public MasterEnemyData Enemy;
    public MasterSkillDataList ItemList;

    // Start is called before the first frame update
    void Awake()
    {
        Repository.Set(new Global());

        var wareHouse = new Warehouse
        {
            Weapons = ItemList.Items.Select(x => new Skill(x)).ToList()
        };
        Repository.Set(wareHouse);

        var pt = new Party();
        pt.Actors[0] = new Actor(Actor1);
        pt.Actors[1] = new Actor(Actor2);
        Repository.Set(pt);

        Repository.Set(new Enemy(Enemy));
    }
}
