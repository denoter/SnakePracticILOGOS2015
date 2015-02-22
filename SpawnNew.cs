using UnityEngine;
using System.Collections;

public class SpawnNew : MonoBehaviour {
	public GameObject food1;


	void Update () {
		if (Food.foodEaten == true) 
		{
			GenerateNewFood();
			Food.foodEaten = false;
			
			
		}

	}
	public static void GenerateNewFood(){
		//string pathGM = "Assets/Prefabs/Food.prefab";
	// создаем экземпляр еды, предварительно загружая префаб из ресурсов
	GameObject food = (GameObject)Instantiate(Resources.Load("food1", typeof(GameObject)));

	
	// цикл подбора положения еды
	while (true)
	{
		// ставим еду в рандомное место
			food.transform.position = new Vector3(Random.Range(-14f, 12f), 0, Random.Range(-7.4f, 7.4f));
		// получаем размер ее колайдера в мировых координатах
		Bounds foodBounds = food.collider.bounds;
		
		bool intersects = false;
		
		// Проверяем со всеми колайдерами кроме колайдера самой еды.
		// Данная фукнция использует габаритные контейнеры колайдеров для
		// сравнения. Если используются сложные колайдеры в уровне, то
		// данное сравнение будет не верным.
		foreach (Collider objectColiider in FindObjectsOfType(typeof(Collider)))
		{
			// проверяем со всеми коллайдерами, кроме коллайдера созданной еды 
			if (objectColiider != food.collider)
			{
				// если пересекается, то завершаем цикл, досрочно
				if (objectColiider.bounds.Intersects(foodBounds))
				{
					intersects = true;
					break;
				}
			}
		}
		
		// установили в нужное место, останавливаем цикл установки
		if (!intersects)
		{
			break;
		}
	}
}
}