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

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        GameObject button;
        for (int i = 0; i < 4; i++)
        {
            button = Instantiate(ButtonPrefab, transform);
            button.GetComponent<CommandButton>().BattleManager = BattleManager;
            button.transform.Find("Name").GetComponent<Text>().text = $"スキル{i}";
            _buttons.Add(button);
        }

        button = Instantiate(ButtonPrefab, transform);
        button.GetComponent<CommandButton>().BattleManager = BattleManager;
        button.transform.Find("Name").GetComponent<Text>().text = "装備変更";
        button.transform.Find("Value").GetComponent<Text>().text = "∞";
        _buttons.Add(button);

        button = Instantiate(ButtonPrefab, transform);
        button.GetComponent<CommandButton>().BattleManager = BattleManager;
        button.transform.Find("Name").GetComponent<Text>().text = "交代";
        button.transform.Find("Value").GetComponent<Text>().text = "∞";
        _buttons.Add(button);
    }

    private void OnDisable()
    {
        foreach (var button in _buttons)
        {
            Destroy(button);
        }
        _buttons.Clear();
    }
}
