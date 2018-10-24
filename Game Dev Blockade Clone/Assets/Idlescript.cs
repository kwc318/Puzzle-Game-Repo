using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;



public class Idlescript : MonoBehaviour
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
	public float timer1;
	public float timer2;
	public float idletimer;
	public float pause;
	public float state;
	public GameObject P1;
	public GameObject P2;
	public GameObject block;
	public Collisionp1 p1script;
	public Collisionp2 p2script;
	public bool move;
	public float losetime;
	public TextMeshProUGUI p1end;
	public TextMeshProUGUI p2end;
	public TextMeshProUGUI gameover;
	public AudioSource beep;
	public AudioSource boop;
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
		timer2 = 0.3f;
	}

	void Update()
	{
		
		timer1 -= Time.deltaTime;
		timer2 -= Time.deltaTime;
		idletimer -= Time.deltaTime;

		if (idletimer <= 0)
		{
			state = Random.Range(0, 5);
			Debug.Log(state);
			idletimer = Random.Range(1, 6);
		}
		
		if (timer1 <= 0 && move == true)
		{
			pos += new Vector3(xspeed,yspeed,0);
			timer1 = pause;
			Instantiate(block, pos - new Vector3(x1,y1,-10), Quaternion.identity);
			beep.Play();
		}

		if (timer2 <= 0 && move == true)
		{
			pos2 += new Vector3(x2speed,y2speed,0);
			timer2 = pause;
			Instantiate(block, pos2 - new Vector3(x2,y2,-10), Quaternion.identity);
			boop.Play();
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

		if (p1script.win == false || p2script.win == false)
		{
			losetime -= Time.deltaTime;
			if (losetime <= 0)
			{
				P1.transform.rotation = Quaternion.Euler(0,0,270);
				x1 = 0;
				y1 = -0.25f;
				pos = new Vector3(-3,3,0);
				yspeed = -0.25f;
				p1script.win = true;
				P2.transform.rotation = Quaternion.Euler(0,0,90);
				x2 = 0;
				y2 = 0.25f;
				pos2 = new Vector3(3,-3,0);
				y2speed = 0.25f;
				p2script.win = true;
				losetime = 5;
				move = true;
				timer2 = 0.1f;
				GameObject[] pblocks = GameObject.FindGameObjectsWithTag("Finish");
				foreach(GameObject pb in pblocks)
					GameObject.Destroy(pb);
				
				if (p1script.score == 6 || p2script.score == 6)
				{
					Debug.Log("Game Over");
					Destroy(this);
					Destroy(P1);
					Destroy(P2);
					p1end.text = p2script.score.ToString();
					p2end.text = p1script.score.ToString();
					gameover.text = "Game\nOver";
				}
			}
		}
	}

}

