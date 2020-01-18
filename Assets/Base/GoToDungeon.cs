using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToDungeon : MonoBehaviour
{
    private Button _button;

    public void Start()
    {
        _button = GetComponent<Button>();
    }

    public void Execute()
    {
        if (!_button.interactable) return;
        SceneManager.LoadScene("Dungeon");
    }
}
