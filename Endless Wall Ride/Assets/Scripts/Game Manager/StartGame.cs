using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
        int rand = Random.Range(0, 2);
		if(rand == 0)
        {
            Instantiate(player, new Vector3(-2.125f, 0, 0), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
