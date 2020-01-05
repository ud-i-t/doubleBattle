using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorViewModel : MonoBehaviour
{
    public Actor Actor;
    public MasterActorData MasterData;

    public void Awake()
    {
        Actor = new Actor();
    }
}
