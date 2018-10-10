using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public float speed;
	public float timer;
	public float pause;
	Vector3 pos;
	Transform tr;

	void Start()
	{
		pos = transform.position;
		tr = transform;
	}

	void Update()
	{
		
		timer -= Time.deltaTime;

		if (timer < 0)
		{
			pos += new Vector3(speed,0,0);
			timer = pause;
		}
		/*

		else if (Input.GetKey(KeyCode.A) && tr.position == pos)
		{
			pos += Vector3.left;
		}
		else if (Input.GetKey(KeyCode.W) && tr.position == pos)
		{
			pos += Vector3.up;
		}
		else if (Input.GetKey(KeyCode.S) && tr.position == pos)
		{
			pos += Vector3.down;
		}
*/

		transform.position = pos;
	}
}

