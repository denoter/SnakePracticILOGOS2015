using UnityEngine;
using System.Collections;

public class Results : MonoBehaviour {
	public UILabel scoreLabel;
	// Use this for initialization
	void Start () {
		scoreLabel.text ="GAME OVER \n Your score : "+  GameManager.points + "";
	}
	
	void mainmenuload () {
		Application.LoadLevel ("MainMeniNGUI");
	}
}
