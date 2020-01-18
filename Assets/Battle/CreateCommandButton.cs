using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateCommandButton : MonoBehaviour
{
    public GameObject ButtonPrefab;
    public BattleManager BattleManager;

    private IList<GameObject> _buttons = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        var pt = Repository.Get<Party>();
        GameObject button;
        CommandButton script;
        foreach (var skill in pt.Actors[1].Skills)
        {
            button = Instantiate(ButtonPrefab, transform);
            script = button.GetComponent<CommandButton>();
            script.Action = () =>
            {
                pt.Actors[1].UseSkill = skill;
                BattleManager.TurnStart();
            };

            button.transform.Find("Name").GetComponent<Text>().text = skill.Name;
            _buttons.Add(button);
        }

        button = Instantiate(ButtonPrefab, transform);
        button.transform.Find("Name").GetComponent<Text>().text = "装備変更";
        button.transform.Find("Value").GetComponent<Text>().text = "∞";
        script = button.GetComponent<CommandButton>();
        script.Action = () =>
        {
            pt.Actors[1].SwitchWeapon();
        };
        script.Enable = () => pt.Actors[1].AllowSwitchWeapon;
        _buttons.Add(button);

        button = Instantiate(ButtonPrefab, transform);
        button.transform.Find("Name").GetComponent<Text>().text = "交代";
        button.transform.Find("Value").GetComponent<Text>().text = "∞";
        script = button.GetComponent<CommandButton>();
        script.Action = () =>
        {
            pt.Switch();
        };
        _buttons.Add(button);
    }

    private void OnDisable()
    {
        //foreach (var button in _buttons)
        //{
        //    Destroy(button);
        //}
        //_buttons.Clear();
    }
}
