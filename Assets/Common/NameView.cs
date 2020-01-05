using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameView : MonoBehaviour
{
    public Battler Battler;
    private Text _label;

    private void Start()
    {
        _label = transform.Find("Label").GetComponent<Text>();
    }

    private void Update()
    {
        _label.text = Battler.Name;
    }
}
