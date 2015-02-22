using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour {
	public float speed = 6;

	public float rotationSpeed = 60;

	public Transform trans;

	private CharacterController _controller;
	// Use this for initialization
	void Start () {
		_controller = GetComponent<CharacterController>();	

	}

	bool testing = false;

	void Update () {

		float horizontal = Input.GetAxis ("Horizontal");
	//	float vertical = Input.GetAxis ("Vertical");

		transform.Rotate(0, rotationSpeed * Time.deltaTime * horizontal, 0);
		_controller.Move(transform.forward * speed * Time.deltaTime );


		testing = true;
	}

	public void OnControllerColliderHit(ControllerColliderHit hit)
	{

		if (testing) 
		{
			Food food = hit.collider.GetComponent<Food>();

			if (food != null)
			{
			food.Eat();
			speed += 0.2f; 
			rotationSpeed += 5;
			AddTail();
			}
			 else 
			{
				if (hit.collider.tag == "Rock"){
					GameManager.lives -=1;
					if (GameManager.lives > 0) {
					Application.LoadLevel("MainScene");
					} else {
						Application.LoadLevel("GameOver");
					}

				}
				//
				//GameManager.lives --;
				// -1 life and Load Level 
			}
		testing = false;
		}
	} 

	//Transform current = transform;
	public void AddTail()
	{
	
		Tail tail = GameObject.CreatePrimitive (PrimitiveType.Cube).AddComponent<Tail>();
		tail.transform.position = trans.transform.position - trans.transform.forward * 2;
		tail.transform.rotation = transform.rotation;
		// элемент хвоста должен следовать за хозяином, поэтому передаем ему ссылку на его
		tail.target = trans.transform;
		// дистанция между элементами хвоста - 2 единицы
		tail.targetDistance = 1;
		// удаляем с хвоста колайдер, так как он не нужен
		Destroy(tail.collider);
		// следующим хозяином будет новосозданный элемент хвоста
		trans = tail.transform;
		
	}

}
