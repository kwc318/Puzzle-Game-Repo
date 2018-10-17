using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionp2 : MonoBehaviour
{

	public PlayerMovement player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Finish"))
		{
			Debug.Log("HIT");
			player.move = false;
			player.xspeed = 0;
			player.yspeed = 0;
			player.x2speed = 0;
			player.y2speed = 0;

		}
	}
}
