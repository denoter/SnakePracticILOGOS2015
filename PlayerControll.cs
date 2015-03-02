using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour {
	public float speed = 6; // скорость персонажа

	public float rotationSpeed = 60; // скорость поворота

	public Transform trans; // переменная для персонажа

	public AudioClip dieSound; // звук при смерти
	public AudioClip eatSound; // звук при подборе еды
	public AudioClip gameOverSound; // звук окончания игры

	public GameObject sparkle; // переменная для партикл системс
	public GameObject TailPrefab;

	public string sceneName;

	private CharacterController _controller;
	// Use this for initialization
	void Start () {
		_controller = GetComponent<CharacterController>();	
		if (GameManager.lives<3 && GameManager.lives>0){
		audio.PlayOneShot (dieSound);
		} 
	}

	bool testing = false;

	void Update () {

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		transform.Rotate(0, rotationSpeed * Time.deltaTime * horizontal, 0);
		_controller.Move(transform.forward * speed * Time.deltaTime * vertical);


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
			sparkle.transform.position = food.transform.position;
			sparkle.SetActive(true);

			audio.PlayOneShot(eatSound);
			
			speed += 0.2f; 
			rotationSpeed += 5;
			AddTail();
			}
			 else 
			{ 
				if (hit.collider.tag == "Rock"){
					GameManager.lives -=1;
					GameManager.size = 0;
					if (GameManager.lives > 0) {
					Application.LoadLevel(sceneName);

					} else {
						Application.LoadLevel("GameOver");
						audio.PlayOneShot(gameOverSound);
					}

				}
			}
		testing = false;
		}
	} 

	//Transform current = transform;
	public void AddTail()
	{ 

		//Tail tail = GameObject.CreatePrimitive (PrimitiveType.Cube).AddComponent<Tail>();
		Tail tail = (GameObject.Instantiate (TailPrefab) as GameObject).AddComponent<Tail> ();
		tail.transform.position = trans.transform.position - trans.transform.forward *2;
		tail.transform.rotation = transform.rotation;
		// ссылка на хозяина
		tail.target = trans.transform;
		tail.targetDistance = 1;
		// следующим хозяином будет новосозданный элемент хвоста
		trans = tail.transform;
		GameManager.size ++;
		
	}



}
