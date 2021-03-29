using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance_Tracker : MonoBehaviour
{
    GameObject Jeremy;
    Vector3 jeremyPosition;
    public float currDistance;
    public Text distanceText;
    public Text highScoreText;

    public float highScore;
    public bool newHighScore = false;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetFloat("HighScore");
        }
        highScoreText.text = "High Score: " + Mathf.Round(highScore);

        Jeremy = GameObject.FindGameObjectWithTag("TheJeremy");
        jeremyPosition = Jeremy.transform.position;
    }

    void Update()
    {
        //track jeremy's current position
        jeremyPosition = Jeremy.transform.position;

        if (jeremyPosition.x > currDistance)
        {
            currDistance = jeremyPosition.x;
        }

        if (currDistance > highScore)
        {
            highScore = currDistance;
            PlayerPrefs.SetFloat("HighScore", highScore);
            highScoreText.text = "High Score: " + Mathf.Round(currDistance);
            newHighScore = true;
        }

        distanceText.text = "Distance: " + Mathf.Round(currDistance);
    }
}
