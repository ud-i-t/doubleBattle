using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateWeaponList : MonoBehaviour
{
    public GameObject ButtonPrefab;

    // Start is called before the first frame update
    void Start()
    {
        var wareHouse = Repository.Get<Warehouse>();

        foreach(var item in wareHouse.Weapons)
        {
            GameObject button = Instantiate(ButtonPrefab, transform);
            button.transform.Find("Name").GetComponent<Text>().text = item.Name;

            var script = button.GetComponent<SwapEquipButton>();
            script.Actor = Repository.Get<Party>().Actors[0];
            script.Skill = item;
            script.SlotID = 0;
        }
    }
}
