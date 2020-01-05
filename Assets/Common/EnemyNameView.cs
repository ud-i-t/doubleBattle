using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyNameView : MonoBehaviour
{
    public EnemyViewModel VM;
    private Text _label;

    private void Start()
    {
        _label = transform.Find("Label").GetComponent<Text>();
    }

    private void Update()
    {
        _label.text = VM.Model.Name;
    }
}
