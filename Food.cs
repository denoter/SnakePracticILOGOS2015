using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {
	public int points = 10;

	public static bool  foodEaten;

	public void Update()
	{
		transform.Rotate (Vector3.up, 60 * Time.deltaTime);
	}

	public void Eat() 
	{
		GameManager.points += points;
		Destroy (gameObject);
		foodEaten = true;


	}

}
