﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour {

    public string EnterScene;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Joystick1Button1))
        {
            Debug.Log("Name Scene: " + EnterScene);
            SceneManager.LoadScene(EnterScene);
        }
    }
}