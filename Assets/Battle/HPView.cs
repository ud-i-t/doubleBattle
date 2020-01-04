using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPView : MonoBehaviour
{
    public Actor Actor;

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
        _hp.text = Actor.HP.ToString();
        _mhp.text = Actor.MaxHP.ToString();
    }
}
