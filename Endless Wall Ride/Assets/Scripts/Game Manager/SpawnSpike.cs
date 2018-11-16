using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpike : MonoBehaviour {

    public int leftRight;
    public GameObject spikeLeft;
    public GameObject spikeRight;
    public GameObject spikeRow;
    private int lastSpike = 2;
    private int preLastSpike = 2;

	// Use this for initialization
	void Start () {
        leftRight = Random.Range(0, 2);
        lastSpike = transform.parent.gameObject.GetComponent<SpawnSpikes>().lastSpike;
        preLastSpike = transform.parent.gameObject.GetComponent<SpawnSpikes>().preLastSpike;

        if (leftRight == 0 && lastSpike != 1)
        {
            Instantiate(spikeLeft, new Vector3(-2.25f, 11, 0), Quaternion.identity, transform);
            transform.parent.gameObject.GetComponent<SpawnSpikes>().lastSpike = 0;
        }
        else if(leftRight > 0 && lastSpike != 0)
        {
            Instantiate(spikeRight, new Vector3(2.25f, 11, 0), Quaternion.identity, transform);
            transform.parent.gameObject.GetComponent<SpawnSpikes>().lastSpike = 1;
        }
        else
        {
            transform.parent.gameObject.GetComponent<SpawnSpikes>().preLastSpike = lastSpike;
            transform.parent.gameObject.GetComponent<SpawnSpikes>().lastSpike = 2;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
