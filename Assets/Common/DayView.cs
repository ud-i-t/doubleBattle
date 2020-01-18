using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayView : MonoBehaviour
{
    private Text _text;

    void Start()
    {
        _text = transform.Find("Value").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = Repository.Get<Global>().Day.ToString();
    }
}
