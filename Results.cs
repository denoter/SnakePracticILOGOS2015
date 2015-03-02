using UnityEngine;
using System.Collections;
//using System.IO;
using System;

public class Results : MonoBehaviour {
	public UILabel scoreLabel;
	public GameObject nameInput;
	public GameObject saveButton;

	public string filename = "Results.txt";
//	private string nameInfo;
	// Use this for initialization
	void Start () {
		scoreLabel.text ="GAME OVER \n Your score : "+  GameManager.points + "";
		NGUITools.SetActive(saveButton, false); // для вебплеера
		NGUITools.SetActive(nameInput, false); // для вебплеера
	}

	void Update() 
	{

	} 

	void mainmenuload () {
		Application.LoadLevel ("MainMeniNGUI");
	}
	void saveresult() {
		/* выключается для вебплеер билда */
		/* string nameInfo = nameInput.GetComponent<UIInput> ().text;
		if (nameInfo == "" || nameInfo == "Enter your name") {
			scoreLabel.text = "ENTER NAME PLEASE";				
		} else {
			if (!File.Exists(filename)){
			StreamWriter sw = new StreamWriter(filename);
				sw.WriteLine("Your name: "+ nameInfo+ "| Your Score: "+ GameManager.points);
				NGUITools.SetActive(saveButton, false);
				sw.Close ();
				scoreLabel.text = "Result in game folder";	
			} else {
				StreamWriter sw1 = File.AppendText(filename);
				sw1.WriteLine("Your name: "+ nameInfo+ "| Your Score: "+ GameManager.points);
				sw1.Close ();
				NGUITools.SetActive(saveButton, false);
				scoreLabel.text = "Result in game folder";	
			}
		} */
	}
}
