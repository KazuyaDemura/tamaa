﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagDirector : MonoBehaviour {

    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("ClearScene");
    }
}
