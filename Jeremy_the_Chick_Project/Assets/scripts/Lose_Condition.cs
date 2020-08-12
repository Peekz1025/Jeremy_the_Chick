using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose_Condition : MonoBehaviour
{
    public GameObject jeremyPrefab;
    public GameObject gameOverUI;
    public GameObject pauseButton;
    public static bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {
        if (jeremyPrefab.transform.position.y < -10)
        {
            //if (isGameOver == false) //causes error, idk why
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
        isGameOver = true;
    }
}
