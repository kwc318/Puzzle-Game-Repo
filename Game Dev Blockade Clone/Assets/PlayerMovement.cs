﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{

	public float xspeed;
	public float yspeed;
	public float x2speed;
	public float y2speed;
	private float x1;
	private float y1;
	private float x2;
	private float y2;
	public float speed;
	public float timer;
	public float pause;
	public GameObject P1;
	public GameObject P2;
	public GameObject block;
	public bool move;
	public Sprite Plose;
	public Sprite P1move;
	public Sprite P2move;
	Vector3 pos;
	Vector3 pos2;
	Transform tr;

	void Start()
	{
		pos = P1.transform.position;
		pos2 = P2.transform.position;
		xspeed = 0;
		x2speed = 0;
		yspeed = -0.25f;
		y2speed = 0.25f;
		x1 = 0;
		y1 = -0.25f;
		x2 = x1;
		y2 = 0.25f;
		move = true;
	}

	void Update()
	{
		
		timer -= Time.deltaTime;

		if (timer < 0)
		{
			pos += new Vector3(xspeed,yspeed,0);
			pos2 += new Vector3(x2speed,y2speed,0);
			timer = pause;		
			Instantiate(block, pos - new Vector3(x1,y1,-10), Quaternion.identity);
			Instantiate(block, pos2 - new Vector3(x2,y2,-10), Quaternion.identity);
		}

		if (Input.GetKeyDown(KeyCode.W) && move == true)
		{
			xspeed = 0;
			yspeed = speed;
			x1 = 0;
			y1 = 0.25f;
			P1.transform.rotation = Quaternion.Euler(0,0,90);
			Debug.Log("W");
		
		}
		
		if (Input.GetKeyDown(KeyCode.D)&& move == true)
		{
			yspeed = 0;
			xspeed = speed;
			x1 = 0.25f;
			y1 = 0;
			P1.transform.rotation = Quaternion.Euler(0,0,0);
			Debug.Log("D");
		
		}
		
		if (Input.GetKeyDown(KeyCode.A)&& move == true)
		{
			yspeed = 0;
			xspeed = -speed;
			x1 = -0.25f;
			y1 = 0;
			P1.transform.rotation = Quaternion.Euler(0,0,180);
			Debug.Log("A");
		
		}
		
		if (Input.GetKeyDown(KeyCode.S)&& move == true)
		{
			xspeed = 0;
			yspeed = -speed;
			x1 = 0;
			y1 = -0.25f;
			P1.transform.rotation = Quaternion.Euler(0,0,270);
			Debug.Log("S");
		
		}
		
		
		if (Input.GetKeyDown(KeyCode.UpArrow)&& move == true)
		{
			x2speed = 0;
			y2speed = speed;
			x2 = 0;
			y2 = 0.25f;
			P2.transform.rotation = Quaternion.Euler(0,0,90);
			Debug.Log("W");
		
		}
		
		if (Input.GetKeyDown(KeyCode.RightArrow)&& move == true)
		{
			y2speed = 0;
			x2speed = speed;
			x2 = 0.25f;
			y2 = 0;
			P2.transform.rotation = Quaternion.Euler(0,0,0);
			Debug.Log("D");
		
		}
		
		if (Input.GetKeyDown(KeyCode.LeftArrow)&& move == true)
		{
			y2speed = 0;
			x2speed = -speed;
			x2 = -0.25f;
			y2 = 0;
			P2.transform.rotation = Quaternion.Euler(0,0,180);
			Debug.Log("A");
		
		}
		
		if (Input.GetKeyDown(KeyCode.DownArrow)&& move == true)
		{
			x2speed = 0;
			y2speed = -speed;
			x2 = 0;
			y2 = -0.25f;
			P2.transform.rotation = Quaternion.Euler(0,0,270);
			Debug.Log("S");
		
		}
		

		P1.transform.position = pos;
		P2.transform.position = pos2;
		
	}

}

