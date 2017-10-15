﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void LoadAct1()
    {
        SceneManager.LoadScene("Act1", LoadSceneMode.Single);
    }

    public void LoadCreate()
    {
        SceneManager.LoadScene("Create", LoadSceneMode.Single);
    }

    public void LoadStartUp()
    {
        SceneManager.LoadScene("startUp", LoadSceneMode.Single);
    }

    public void LoadLoad()
    {
        SceneManager.LoadScene("Load", LoadSceneMode.Single);
    }
}
