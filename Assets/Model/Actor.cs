using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public int MaxHP { get; set; } = 50;
    public int HP { get; set; }
    public int MaxST { get; set; } = 12;
    public int ST { get; set; }

    public Actor()
    {
        HP = MaxHP;
        ST = MaxST;
    }
}
