using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPView : MonoBehaviour
{
    public int Number;

    private Text _hp;
    private Text _mhp;

    // Start is called before the first frame update
    void Start()
    {
        _hp = transform.Find("Current").GetComponent<Text>();
        _mhp = transform.Find("Max").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        var pt = Repository.Get<Party>();
        _hp.text = pt.Actors[Number].HP.ToString();
        _mhp.text = pt.Actors[Number].MaxHP.ToString();
    }
}
