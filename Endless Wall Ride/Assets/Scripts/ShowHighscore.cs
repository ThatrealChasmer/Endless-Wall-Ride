using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowHighscore : MonoBehaviour {

    public Text highscore;

	// Use this for initialization
	void Start () {
        highscore.text = Static.highscore.ToString();
	}

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
