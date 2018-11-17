using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

    float timeScale;
    public int score;
    public Text scoreText;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = score.ToString();
	}

    public void SetScore(int score)
    {
        this.score = score;
    }

    public int GetScore()
    {
        return this.score;
    }

    public void Pause()
    {
        timeScale = Time.timeScale;
        Time.timeScale = 0;
    }

    public void Unpause()
    {
        Time.timeScale = timeScale;
    }
}
