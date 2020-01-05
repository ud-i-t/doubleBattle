using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public int MaxHP { get; set; } = 50;

    private int _hp;
    public int HP
    {
        get { return _hp; }
        set
        {
            _hp = value;
            if (_hp < 0) _hp = 0;
            if (_hp > MaxHP) _hp = MaxHP;
        }
    }

    public int MaxST { get; set; } = 12;
    public int ST { get; set; }

    public void Action()
    {
        HP--;
    }

    public Actor()
    {
        HP = MaxHP;
        ST = MaxST;
    }
}
