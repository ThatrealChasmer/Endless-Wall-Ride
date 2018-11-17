using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpike : MonoBehaviour {

    public int leftRight;
    public GameObject spikeLeft;
    public GameObject spikeRight;
    public GameObject spikeRow;
    private int lastSpike;
    private int fixedSpike;

	// Use this for initialization
	void Start () {
        
        lastSpike = transform.parent.gameObject.GetComponent<SpawnSpikes>().lastSpike;
        fixedSpike = transform.parent.gameObject.GetComponent<SpawnSpikes>().fixedSpike;
        if (fixedSpike == 0)
        {
            leftRight = 0;
        }
        else if (fixedSpike == 1)
        {
            leftRight = 1;
        }
        else
        {
            leftRight = Random.Range(0, 2);
        }

        if (leftRight == 0 && lastSpike != 1)
        {
            Instantiate(spikeLeft, new Vector3(-2.25f, 11, 0), Quaternion.identity, transform);
            transform.parent.gameObject.GetComponent<SpawnSpikes>().lastSpike = 0;
            transform.parent.gameObject.GetComponent<SpawnSpikes>().fixedSpike = 2;
        }
        else if(leftRight > 0 && lastSpike != 0)
        {
            Instantiate(spikeRight, new Vector3(2.25f, 11, 0), Quaternion.identity, transform);
            transform.parent.gameObject.GetComponent<SpawnSpikes>().lastSpike = 1;
            transform.parent.gameObject.GetComponent<SpawnSpikes>().fixedSpike = 2;
        }
        else
        {
            if (lastSpike == 0) transform.parent.gameObject.GetComponent<SpawnSpikes>().fixedSpike = 1;
            else if (lastSpike == 1) transform.parent.gameObject.GetComponent<SpawnSpikes>().fixedSpike = 0;
            transform.parent.gameObject.GetComponent<SpawnSpikes>().lastSpike = 2;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
