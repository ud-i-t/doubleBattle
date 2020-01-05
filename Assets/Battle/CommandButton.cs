using Assets.Battle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandButton : MonoBehaviour
{
    public IBattleManager BattleManager { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnExecute()
    {
        BattleManager.TurnStart();
    }
}
