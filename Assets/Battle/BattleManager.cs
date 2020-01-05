﻿using Assets.Battle;
using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour, IBattleManager
{
    public GameObject CommandWindow;
    public BattleMessage MessageWindow;
    public Party Party;
    public Enemy Enemy;

    private void OnEnable()
    {
        StartInput();
    }

    private void OnDisable()
    {
        
    }

    private void StartInput()
    {
        MessageWindow.Message = "コマンド？";
        CommandWindow.SetActive(true);
    }

    public void TurnStart()
    {
        StartCoroutine(TurnAction());
    }

    public IEnumerator TurnAction()
    {
        CommandWindow.SetActive(false);

        Party.actors[1].Action();
        MessageWindow.Message = "後衛の行動";

        yield return StartCoroutine(Wait(60));

        Enemy.Action(Party.actors[0]);
        MessageWindow.Message = "敵の行動";
        yield return StartCoroutine(Wait(60));

        Party.actors[0].Reaction(Enemy);
        MessageWindow.Message = "前衛の反撃";
        yield return StartCoroutine(Wait(60));

        StartInput();
        yield return null;
    }

    private IEnumerator Wait(int frame)
    {
        for(int i = 0; i < frame; i++)
        {
            yield return null;
        }
    }
}
