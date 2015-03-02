using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject food; // food prefab
	public GameObject extraFood;

	public Transform[] spawnPoints;


	private int number;

	void Update () 
	{	
	
	
		if (Food.foodEaten == true) 
		{
			SpawnFood();
			Food.foodEaten = false;		
		}
		if (Food.extraFoodEaten == true && GameManager.size  % 8 == 0  && GameManager.size != 0 )
		{
			SpawnExtraFood();
			Food.extraFoodEaten = false;
		}


	}
	public void SpawnFood()
	{
	number = Random.Range (0, spawnPoints.Length - 1);
		Instantiate(food, spawnPoints[number].position, Quaternion.identity);			
	}
	public void SpawnExtraFood() 
	{

		number = Random.Range (0, spawnPoints.Length - 1);
		Instantiate(extraFood, spawnPoints[number].position, Quaternion.identity);
	}
}
