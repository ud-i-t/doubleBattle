using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repository
{
    private static Dictionary<Type, object> _keyValuePairs = new Dictionary<Type, object>();

    public static T Get<T>(){
        return (T)_keyValuePairs[typeof(T)];
    }

    public static void Set<T>(T obj)
    {
        _keyValuePairs.Add(typeof(T), obj);
    }
}
