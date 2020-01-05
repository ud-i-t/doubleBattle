using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyViewModel : MonoBehaviour
{
    public Enemy Model;
    public MasterEnemyData MasterData;

    public void Awake()
    {
        Model = new Enemy(MasterData);
    }
}
