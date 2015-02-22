using UnityEngine;
using System.Collections;

public class ControlMenu : MonoBehaviour {

	// Use this for initialization
	void playgame () {
		Application.LoadLevel ("MainScene");
	}
	
	// Update is called once per frame
	void exitgame () {
		Application.Quit ();
	}

}
