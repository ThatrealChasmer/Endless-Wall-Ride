using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpike : MonoBehaviour {

    public int leftRight;
    public GameObject spikeLeft;
    public GameObject spikeRight;
    public GameObject spikeRow;

	// Use this for initialization
	void Start () {
        leftRight = Random.Range(0, 2);

        if (leftRight == 0)
        {
            Instantiate(spikeLeft, new Vector3(-2.25f, 11, 0), Quaternion.identity, transform);
        }
        else
        {
            Instantiate(spikeRight, new Vector3(2.25f, 11, 0), Quaternion.identity, transform);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
