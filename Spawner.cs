using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject prefab;
	//private bool foodEnable;
	
	// Update is called once per frame
	void Update () {
		if (Food.foodEaten == true) 
		{
			SpawnFood();
			Food.foodEaten = false;

				
		}
			

		}
 public void SpawnFood()
	{
		//if (foodEnable == true) {
		Instantiate(prefab, new Vector3( Random.Range(-14f, 12f), 1, Random.Range(-7.4f, 7.4f)), Quaternion.identity);
	}
}
