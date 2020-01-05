using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorViewModel : MonoBehaviour
{
    public Actor Model;
    public MasterActorData MasterData;

    public void Awake()
    {
        Model = new Actor(MasterData);
    }
}
