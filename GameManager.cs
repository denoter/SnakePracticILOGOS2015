using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int points = 0;
	public static int lives = 3;

	public UILabel scoreLabel;

	private string pointString;
	private int lastPoints = -1;

	public void Start()
	{

	}
	void Update () 
	{
		if (lastPoints == points)	return;

		lastPoints = points;
		scoreLabel.text = "Score : " + points.ToString ("0000") + " Lives : " + lives;
	}

}
