using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STView : MonoBehaviour
{
    public int Number;

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
        var pt = Repository.Get<Party>();
        _current.text = pt.Actors[Number].ST.ToString();
        _max.text = pt.Actors[Number].MaxST.ToString();
    }
}
