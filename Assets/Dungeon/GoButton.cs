using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoButton : MonoBehaviour
{
    public void SceneChange()
    {
        var enemy = Repository.Get<Enemy>();
        enemy.HP = enemy.MaxHP;
        SceneManager.LoadScene("Battle");
    }
}
