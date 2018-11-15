using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanSpawn : MonoBehaviour {

    private Vector3 startPosition;
    private GameObject spikeSpawner;

	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        spikeSpawner = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= startPosition.y - 1)
        {
            spikeSpawner.GetComponent<SpawnSpikes>().canSpawn = true;
            Destroy(this);
        }
    }
}
