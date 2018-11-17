using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour {

    bool counted = false;
    GameObject gameManager;
	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= 0 && counted == false)
        {
            gameManager.GetComponent<UIHandler>().score += 1;
            counted = true;
        }
    }
}
