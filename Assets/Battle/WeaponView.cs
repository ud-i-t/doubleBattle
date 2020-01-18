using Assets.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponView : MonoBehaviour
{
    private Text _name;
    private Text _power;

    public int Number;

    void Start()
    {
        _name = transform.Find("Name").GetComponent<Text>();
        _power = transform.Find("Power").GetComponent<Text>();
    }

    private void Update()
    {
        var skill = Repository.Get<Party>().Actors[Number].Weapon;
        _name.text = skill.Name;
        _power.text = skill.Power.ToString();
    }
}
