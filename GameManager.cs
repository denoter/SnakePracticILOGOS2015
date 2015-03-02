using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int points = 0;
	public static int lives = 3;
	public static int size = 0;

	public UILabel scoreLabel;
	public UILabel scoreLabel1;

	private string pointString;
	private int lastPoints = -1;


	void Update () 
	{
		if (lastPoints == points)	return;

		lastPoints = points;
		scoreLabel.text = "Score : " + points.ToString ("0000") + " Lives : " + lives + "\n Size : " + size;
		scoreLabel1.text = "Score : " + points.ToString ("0000") + " Lives : " + lives+ "\n Size : " + size;

	}

}
