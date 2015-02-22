using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public GameObject player;
	public float camSpeed ; 
	public float scrollSpeed;
	public float minDistance;
	public float maxDistance;

	private bool isActive = false;
	private float _x;
	private	float _y;
	private float _distance;


	void LateUpdate () {
		_x = Input.GetAxis ("Mouse X") * camSpeed * 10;
		_y = Input.GetAxis ("Mouse Y") * -camSpeed * 10;

		if (Input.GetMouseButtonDown(1)) 
		{
			isActive = true;	
		}

		if (Input.GetMouseButtonUp(1)) 
		{
			isActive = false;	
		}

		if (isActive) 
		{
			transform.RotateAround(player.transform.position, transform.up, _x*Time.deltaTime);
			transform.RotateAround(player.transform.position, transform.right, _y*Time.deltaTime);

			transform.rotation = Quaternion.LookRotation(player.transform.position - transform.position);
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y , 0);

		}
		if (Input.GetAxis("Mouse ScrollWheel") != 0 )
		{
			_distance = Vector3.Distance(transform.position, player.transform.position);
			if (Input.GetAxis ("Mouse ScrollWheel") > 0 && _distance >  minDistance)
			{
				transform.Translate(Vector3.forward * Time.deltaTime * scrollSpeed);
			}
			if (Input.GetAxis ("Mouse ScrollWheel") < 0 && _distance <  maxDistance)
			{
				transform.Translate(Vector3.forward * Time.deltaTime * -scrollSpeed);
			}
		}

	}
}
