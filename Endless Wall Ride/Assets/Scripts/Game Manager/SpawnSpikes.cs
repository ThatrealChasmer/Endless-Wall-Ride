using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpikes : MonoBehaviour {

    public GameObject spikePrefab;
    public GameObject spike;
    public GameObject spikeRow;
    public int leftSpikeCount = 0;
    public int rightSpikeCount = 0;
    public int leftRight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        leftRight = Random.Range(0, 2);
        Debug.Log(leftRight);
        if(leftRight == 0)
        {
            spike = spikePrefab;
            Debug.Log(spike.transform.localScale.x);
            Instantiate(spike, new Vector3(-2, 11, 0), Quaternion.identity);
        }
        else
        {
            spike = Flip(spikePrefab);
            Debug.Log(spike.transform.localScale.x);
            Instantiate(spike, new Vector3(2, 11, 0), Quaternion.identity);
        }

	}

    private GameObject Flip(GameObject prefab)
    {
        GameObject toFlip = prefab;

        float tmpx = -toFlip.transform.localScale.x;

        toFlip.transform.localScale = new Vector3(tmpx, toFlip.transform.localScale.y, toFlip.transform.localScale.z);

        return toFlip;
    }
}
