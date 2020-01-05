using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyViewModel : MonoBehaviour
{
    public Enemy Enemy;
    public MasterEnemyData MasterData;

    public void Awake()
    {
        Enemy = new Enemy();
    }
}
