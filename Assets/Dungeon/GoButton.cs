﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoButton : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Battle");
    }
}
