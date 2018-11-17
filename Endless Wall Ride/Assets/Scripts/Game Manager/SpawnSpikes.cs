using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpikes : MonoBehaviour {

    public GameObject spikeRow;
    public bool canSpawn = true;
    public int lastSpike = 2;
    public int fixedSpike = 2;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (canSpawn == true)
        {
            Instantiate(spikeRow, new Vector3(0, 11, 0), Quaternion.identity, transform);
            canSpawn = false;
        }
        
    }
}
