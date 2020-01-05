using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMessage : MonoBehaviour, IMessage
{
    public string Message { get; set; }

    private Text _message;

    void Start()
    {
        _message = transform.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _message.text = Message;
    }
}
