using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBattler
{
    string Name { get; }
    int MaxHP { get; set; }
    int HP { get; set; }

    void Reaction(IBattler enemy, IMessage message);
}
