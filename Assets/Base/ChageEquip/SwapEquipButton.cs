using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapEquipButton : MonoBehaviour
{
    public Skill Skill { get; set; }
    public Actor Actor { get; set; }
    public int SlotID { get; set; }
    public Action PostExecute { get; set; }

    public void Execute()
    {
        Repository.Get<Warehouse>().Weapons.Add(Actor.Weapon[SlotID]);
        Actor.Weapon[SlotID] = Skill;
        
        PostExecute?.Invoke();
    }
}
