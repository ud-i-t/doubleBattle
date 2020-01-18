using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipButton : MonoBehaviour
{
    public enum Slot
    {
        MainWeapon,
        SubWeapon,
    }

    private Text _name;

    public int Number;
    public Slot SlotType;

    void Start()
    {
        _name = transform.Find("Name").GetComponent<Text>();
    }

    private void Update()
    {
        var actor = Repository.Get<Party>().Actors[Number];

        Skill skill;

        switch(SlotType)
        {
            case Slot.MainWeapon:
                skill = actor.Weapon;
                break;
            case Slot.SubWeapon:
                skill = actor.SubWeapon;
                break;
            default:
                return;
        }

        _name.text = skill.Name;
    }
}
