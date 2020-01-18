using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithdrawalButton : MonoBehaviour
{
    public void Execute()
    {
        Repository.Get<Party>().Heal();
    }
}
