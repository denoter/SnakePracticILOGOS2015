using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {
	public int points = 10;

	public static bool  foodEaten;
	public static bool  extraFoodEaten = true;

	public void Update()
	{
		transform.Rotate (Vector3.up, 60 * Time.deltaTime);
	}

	public void Eat() 
	{

		GameManager.points += points;
		if (gameObject.tag == "Food") 
		{
			Destroy (gameObject);
			foodEaten = true;
		}
		else /*if (gameObject.tag == "ExtraFood")*/{
			Destroy (gameObject);
			extraFoodEaten = true;
		}
	}

}
