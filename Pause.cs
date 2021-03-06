﻿using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	private bool paused = false;
	public Camera cam; 
	public GameObject pauselabel;
	//public GameObject exitButton;

	// Use this for initialization
	void Start () {
		NGUITools.SetActive (pauselabel, true);
//		NGUITools.SetActive (exitButton, true);
		Time.timeScale = 0;
		paused = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (!paused) 
			{
				Time.timeScale = 0;
				paused = true;
				NGUITools.SetActive (pauselabel, true);
				//NGUITools.SetActive (exitButton, true);

			}
			else {
				Time.timeScale = 1;
				paused = false;
				NGUITools.SetActive (pauselabel, false);
				//NGUITools.SetActive (exitButton, false);
			}
		}				
	}
}
