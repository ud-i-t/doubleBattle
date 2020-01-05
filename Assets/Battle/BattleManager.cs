using Assets.Battle;
using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour, IBattleManager
{
    public GameObject CommandWindow;
    public Party Party;
    public Enemy Enemy;

    private void OnEnable()
    {
        CommandWindow.SetActive(true);
    }

    private void OnDisable()
    {
        
    }

    public void TurnStart()
    {
        StartCoroutine(TurnAction());
    }

    public IEnumerator TurnAction()
    {
        CommandWindow.SetActive(false);

        Party.actors[1].Action();

        yield return StartCoroutine(Wait(30));

        Enemy.Action(Party.actors[0]);
        yield return StartCoroutine(Wait(30));

        Party.actors[0].Reaction(Enemy);
        yield return StartCoroutine(Wait(30));

        CommandWindow.SetActive(true);
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
