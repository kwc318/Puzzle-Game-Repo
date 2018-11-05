using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Adapted : MonoBehaviour
{

	public GameObject blocks;
	public GameObject wall;
	public GameObject player1;
	public GameObject player2;
	public GameObject blink;
	public float timer;
	public float pause;
	public float blinktimer;
	public float blinktimerpause;
	public Sprite bl;
	public Sprite box;
	public bool active;
	public Vector3 pos;
	public PlayerMovement player;
	public Collisionp1 col1;
	public Collisionp2 col2;

	// Use this for initialization
	void Start () {
		
		for (int i = 0; i <= 20; i++)
			
		{
			Instantiate(blocks, new Vector3(6.5f - i * 0.3f, 4.5f, 1), Quaternion.identity);
			Instantiate(blocks, new Vector3(-0.5f - i * 0.3f, 4.5f, 1), Quaternion.identity);
		}

		for (int i = 0; i <=43; i++)
		{
			Instantiate(blocks, new Vector3(6.5f - i * 0.3f, -4.5f, 1), Quaternion.identity);       
		}

		for (int i = 0; i <= 30; i++)
		{
			Instantiate(blocks, new Vector3(6.5f, 4.5f - i * 0.3f, 1), Quaternion.identity);
			Instantiate(blocks, new Vector3(-6.5f, 4.5f - i * 0.3f, 1), Quaternion.identity);
		}

		active = true;
		blink.GetComponent<SpriteRenderer>().sprite = bl;
	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;
		//Vector3 position = new Vector3(Random.Range(-6, 6), Random.Range(-4, 4), 0);
		

		if (Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene(sceneName: "Start");
		}

		if (timer <= 3 && active == true)
		{
			pos = new Vector3(Random.Range(-6, 6), Random.Range(-4, 4), 1);
			//Instantiate(blink, position, Quaternion.identity);
			//timer = pause;
			Debug.Log(pos);
			Instantiate(blink, pos, Quaternion.identity);
			active = false;
		}

		/*if (active == false)
		{
			blinktimer -= Time.deltaTime;
			
			if (blinktimer <= 0 && blink.GetComponent<SpriteRenderer>().sprite == bl )
			{
				blink.GetComponent<SpriteRenderer>().sprite = box;
				blinktimer = blinktimerpause;
			}

//			if (blinktimer <= 0 && blink.GetComponent<SpriteRenderer>().sprite == box)
//			{
//				blink.GetComponent<SpriteRenderer>().sprite = bl;
//				blinktimer = blinktimerpause;
//			}
		}*/
		
		if (timer <= 0)
		{
			//blinktimer = blinktimerpause;
			Instantiate(wall, pos, Quaternion.identity);
			active = true;
			timer = pause;
		}

		if (col1.win == false || col2.win == false)
		{
			timer = pause;
			active = true;
		}
	}
}
