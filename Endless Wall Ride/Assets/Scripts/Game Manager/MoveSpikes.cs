using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSpikes : MonoBehaviour {

    private Vector3 startPosition;
    public Vector3 endPosition;

    public float speed;
    private float startTime;

    private float journeyLength;

    // Use this for initialization
    void Start () {
        startPosition = transform.position;
        startTime = Time.time;
        journeyLength = Vector3.Distance(startPosition, endPosition);
    }
	
	// Update is called once per frame
	void Update () {

        float distCovered = (Time.time - startTime) * speed;

        float fracJourney = distCovered / journeyLength;

        transform.position = Vector3.Lerp(startPosition, endPosition, fracJourney);

        if (transform.position.y == endPosition.y)
        {
            if(Time.timeScale <= 10f)
            {
                Time.timeScale = Time.timeScale + 0.03f;
            }
            Debug.Log(Time.timeScale);
            Destroy(gameObject);
        }

	}
}
