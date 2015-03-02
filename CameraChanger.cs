using UnityEngine;
using System.Collections;

public class CameraChanger : MonoBehaviour {

	public GameObject camera1;
	public GameObject camera2;
	
	public Camera camera11;
	public Camera camera22;
	
	
	void Start() {
		camera1.SetActive (false);
		camera2.SetActive (true);
		camera11.enabled = false;
		camera22.enabled = true;

		if (ControlMenu.isCameraChanged == 1)
		{ 
			camera1.SetActive (true);
			camera2.SetActive (false);
			camera11.enabled = true;
			camera22.enabled = false;
		} else {
			camera1.SetActive (false);
			camera2.SetActive (true);
			camera11.enabled = false;
			camera22.enabled = true;
		}

	}
	
	void Update() {
		//This will toggle the enabled state of the two cameras between true and false each time
		if (Input.GetKeyUp(KeyCode.C)) {
			camera1.SetActive (true);
			camera2.SetActive (false);
			camera11.enabled = true;
			camera22.enabled = false;
		}
		if (Input.GetKeyUp(KeyCode.V)) {
			camera1.SetActive (false);
			camera2.SetActive (true);
			camera11.enabled = false;
			camera22.enabled = true;
			
		}
	}
}
