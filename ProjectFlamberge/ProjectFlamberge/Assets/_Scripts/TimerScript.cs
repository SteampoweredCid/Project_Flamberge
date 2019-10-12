using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour {
    public Text timer;
    private float startTime;
    private float t;
	// Use this for initialization
	void Start () {
        startTime = 0; // in seconds
        t = startTime;
	}
	
	// Update is called once per frame
	void Update () {
        t = t + Time.deltaTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timer.text = minutes + ":" + seconds;

        if (t > 180)
        {
            gameOver();
        }
	}

    void gameOver()
    {
        timer.text = "GAME OVER";
        SceneManager.LoadScene("GameOver");
    }
}
