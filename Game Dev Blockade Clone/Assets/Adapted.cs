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
	public float timer;
	public float pause;
	public float btimer;
	public float bpause;

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
	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;
		btimer -= Time.deltaTime;
		Vector3 position = new Vector3(Random.Range(-6, 6), Random.Range(-4, 4), 0);
		Debug.Log(position);

		if (Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene(sceneName: "Start");
		}

		if (timer <= 0)
		{
			Instantiate(wall, position, Quaternion.identity);
			timer = pause;
		}

		if (btimer <= 0)	
		{
			
		}
	}
}
