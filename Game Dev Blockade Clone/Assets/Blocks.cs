using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blocks : MonoBehaviour
{

	public GameObject blocks;
	public GameObject player1;
	public GameObject player2;

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
		
		if (Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
