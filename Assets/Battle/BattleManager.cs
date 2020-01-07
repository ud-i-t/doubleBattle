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
    public Enemy Enemy;

    private void OnEnable()
    {
        Party = Repository.Get<Party>();
        Enemy = Repository.Get<Enemy>();
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

        Party.Actors[1].Action(Enemy, MessageWindow);
        yield return StartCoroutine(Wait(60));

        Enemy.Skills.First().Use(Enemy, Party.Actors[0], MessageWindow);
        yield return StartCoroutine(Wait(60));

        Party.Actors[0].Reaction(Enemy, MessageWindow);
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
