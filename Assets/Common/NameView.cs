using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameView : MonoBehaviour
{
    public int Number;
    private Text _label;

    private void Start()
    {
        _label = transform.Find("Label").GetComponent<Text>();
    }

    private void Update()
    {
        var pt = Repository.Get<Party>();
        _label.text = pt.Actors[Number].Name;
    }
}
