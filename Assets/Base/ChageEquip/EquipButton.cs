using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipButton : MonoBehaviour
{
    private Text _name;

    public int Number;
    public int SlotId;

    void Start()
    {
        _name = transform.Find("Name").GetComponent<Text>();
    }

    private void Update()
    {
        var actor = Repository.Get<Party>().Actors[Number];
        _name.text = actor.Weapon[SlotId].Name;
    }
}
