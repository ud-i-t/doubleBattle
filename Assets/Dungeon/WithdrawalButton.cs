using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WithdrawalButton : MonoBehaviour
{
    public void Execute()
    {
        Repository.Get<Party>().Heal();
        Repository.Get<Global>().Day++;
        SceneManager.LoadScene("Base");
    }
}
