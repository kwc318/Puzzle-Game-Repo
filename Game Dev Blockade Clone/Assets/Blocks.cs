using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{

	public GameObject blocks;
	public GameObject player1;
	public GameObject player2;

	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < 41; i++)
			
        		{
        			Instantiate(blocks, new Vector3(6 - i * 0.3f, 4.5f, 0), Quaternion.identity);
			        Instantiate(blocks, new Vector3(6 - i * 0.3f, -4.5f, 0), Quaternion.identity);       
        		}

		for (int i = 0; i < 31; i++)
		{
			Instantiate(blocks, new Vector3(6, 4.5f - i * 0.3f, 0), Quaternion.identity);
			Instantiate(blocks, new Vector3(-6, 4.5f - i * 0.3f, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {


	}
}
