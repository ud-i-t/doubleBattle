﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STView : MonoBehaviour
{
    public ActorViewModel Actor;

    private Text _current;
    private Text _max;

    // Start is called before the first frame update
    void Start()
    {
        _current = transform.Find("Current").GetComponent<Text>();
        _max = transform.Find("Max").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _current.text = Actor.Model.ST.ToString();
        _max.text = Actor.Model.MaxST.ToString();
    }
}
