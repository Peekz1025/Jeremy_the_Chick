using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Log_test : MonoBehaviour
{

    public GameObject text;


    // Update is called once per frame
    void Update()
    {
        Debug.Log("the game is running");
        Debug.Log(Time.timeScale);

        text.GetComponent<UnityEngine.UI.Text>().text = Time.timeScale.ToString();

    }

    public void SetTime()
    {
        Time.timeScale = 1f;
    }


    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Time.timeScale = 1;
    }

}
