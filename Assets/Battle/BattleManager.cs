using Assets.Battle;
using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleManager : MonoBehaviour, IBattleManager
{
    public GameObject CommandWindow;
    public BattleMessage MessageWindow;
    public Party Party;
    public EnemyViewModel Enemy;

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

        Party.actors[1].Model.Action(Enemy.Model, MessageWindow);
        yield return StartCoroutine(Wait(60));

        Enemy.Model.Skills.First().Use(Enemy.Model, Party.actors[0].Model, MessageWindow);
        yield return StartCoroutine(Wait(60));

        Party.actors[0].Model.Reaction(Enemy.Model, MessageWindow);
        yield return StartCoroutine(Wait(60));

        StartInput();
        yield return null;
    }

    private IEnumerator Wait(int frame)
    {
        for (int i = 0; i < frame; i++)
        {
            yield return null;
        }
    }
}
