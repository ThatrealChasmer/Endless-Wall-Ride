using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    private bool isMoving = false;
    public float speed;
    public float distance;
    public float startTime;
    private Vector3 leftPosition;
    private Vector3 rightPosition;
    private Vector3 startPosition;
    private Vector3 endPosition;
    public GameObject gameManager;

    // Use this for initialization
    void Start() {
        rightPosition = new Vector3(2.25f, 0, 0);
        leftPosition = new Vector3(-2.25f, 0, 0);

        gameManager = GameObject.FindGameObjectWithTag("GameController");
        Debug.Log(gameManager.name);
    }

    // Update is called once per frame
    void Update() {
        Debug.Log(isMoving);
        if (isMoving == true)
        {

            Debug.Log(startPosition + " " + endPosition + " " + distance + " " + startTime);

            Debug.Log(Time.time);
            float distCovered = (Time.time - startTime) * speed;
            Debug.Log("distCovered = " + distCovered);

            float fracJourney = distCovered / distance;
            Debug.Log("fracJourney = " + fracJourney);


            transform.position = Vector3.Lerp(startPosition, endPosition, fracJourney);

            if (transform.position == endPosition)
            {
                isMoving = false;
            }
        }
        else
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

                Debug.Log(touchPosition);

                if (touchPosition.x >= 0 && transform.position.x < 0)
                {
                    startPosition = leftPosition;
                    endPosition = rightPosition;
                    distance = Vector3.Distance(startPosition, endPosition);
                    startTime = Time.time;

                    isMoving = true;
                }
                else if (touchPosition.x < 0 && transform.position.x > 0)
                {
                    startPosition = rightPosition;
                    endPosition = leftPosition;
                    distance = Vector3.Distance(startPosition, endPosition);
                    startTime = Time.time;

                    isMoving = true;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().CompareTag("Spike"))
        {
            Time.timeScale = 1;
            Static.score = gameManager.gameObject.GetComponent<UIHandler>().score;
            if(Static.score > Static.highscore)
            {
                Static.highscore = Static.score;
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
