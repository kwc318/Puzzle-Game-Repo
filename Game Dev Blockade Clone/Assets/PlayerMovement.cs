using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{

	private float xspeed;
	private float yspeed;
	private float x2speed;
	private float y2speed;
	public float speed;
	public float timer;
	public float pause;
	public GameObject P1;
	public GameObject P2;
	Vector3 pos;
	Vector3 pos2;
	Transform tr;

	void Start()
	{
		pos = P1.transform.position;
		pos2 = P2.transform.position;
		xspeed = 0;
		x2speed = 0;
		yspeed = -0.5f;
		y2speed = 0.5f;
		
	}

	void Update()
	{
		
		timer -= Time.deltaTime;

		if (timer < 0)
		{
			pos += new Vector3(xspeed,yspeed,0);
			pos2 += new Vector3(x2speed,y2speed,0);
			timer = pause;		
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			xspeed = 0;
			yspeed = speed;
			P1.transform.rotation = Quaternion.Euler(0,0,90);
			Debug.Log("W");
		
		}
		
		if (Input.GetKeyDown(KeyCode.D))
		{
			yspeed = 0;
			xspeed = speed;
			P1.transform.rotation = Quaternion.Euler(0,0,0);
			Debug.Log("D");
		
		}
		
		if (Input.GetKeyDown(KeyCode.A))
		{
			yspeed = 0;
			xspeed = -speed;
			P1.transform.rotation = Quaternion.Euler(0,0,180);
			Debug.Log("A");
		
		}
		
		if (Input.GetKeyDown(KeyCode.S))
		{
			xspeed = 0;
			yspeed = -speed;
			P1.transform.rotation = Quaternion.Euler(0,0,270);
			Debug.Log("S");
		
		}
		
		
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			x2speed = 0;
			y2speed = speed;
			P2.transform.rotation = Quaternion.Euler(0,0,90);
			Debug.Log("W");
		
		}
		
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			y2speed = 0;
			x2speed = speed;
			P2.transform.rotation = Quaternion.Euler(0,0,0);
			Debug.Log("D");
		
		}
		
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			y2speed = 0;
			x2speed = -speed;
			P2.transform.rotation = Quaternion.Euler(0,0,180);
			Debug.Log("A");
		
		}
		
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			x2speed = 0;
			y2speed = -speed;
			P2.transform.rotation = Quaternion.Euler(0,0,270);
			Debug.Log("S");
		
		}
		

		P1.transform.position = pos;
		P2.transform.position = pos2;
		
	}

}

