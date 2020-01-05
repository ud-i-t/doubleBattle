using Assets.Battle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour, IBattleManager
{
    public GameObject CommandWindow;

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

        yield return StartCoroutine(Wait(60));

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
