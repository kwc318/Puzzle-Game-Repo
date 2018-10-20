using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collisionp2 : MonoBehaviour
{

	public PlayerMovement player;
	public Sprite Plose;
	public Sprite P2move;
	public float timer;
	public float pause;
	public bool win;
	public int score;
	public TextMeshProUGUI p1score;

	// Use this for initialization
	void Start ()
	{
		win = true;
	}
	
	// Update is called once per frame
	void Update () {
				
		if ( win == false)       			            
		{
			timer -= Time.deltaTime;
			if (timer <= 0 && GetComponent<SpriteRenderer>().sprite == Plose)
			{
				GetComponent<SpriteRenderer>().sprite = P2move;
				p1score.text = score.ToString();
				timer = pause;
			}

			if (timer <= 0 && GetComponent<SpriteRenderer>().sprite == P2move)
			{
				GetComponent<SpriteRenderer>().sprite = Plose;
				p1score.text = "";
				timer = pause;
			}

		}
		
		else
		{
			GetComponent<SpriteRenderer>().sprite = P2move;
			p1score.text = "";
		}
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Finish") || other.gameObject.CompareTag("Respawn"))
		{
			Debug.Log("HIT");
			player.move = false;
			player.xspeed = 0;
			player.yspeed = 0;
			player.x2speed = 0;
			player.y2speed = 0;
			score += 1;
			GetComponent<SpriteRenderer>().sprite = Plose;
			win = false;
			Debug.Log("P1 " + score);
		}
	}
}
