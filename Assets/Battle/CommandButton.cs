using Assets.Battle;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandButton : MonoBehaviour
{
    public Action Action { get; set; }
    public Func<bool> Enable { get; set; }

    private Button _button;

    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Enable == null) return;
        _button.interactable = Enable();
    }

    public void OnExecute()
    {
        if (!_button.interactable) return;
        Action?.Invoke();
    }
}
