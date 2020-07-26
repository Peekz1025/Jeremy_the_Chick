using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{


    public void LoadGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("game");
        Time.timeScale = 1f;
    }

    public void LoadHome()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("home");
    }


    public void ReloadGame()
    {
        Debug.Log("entered reload game");
        Time.timeScale = 1f;
        //SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
