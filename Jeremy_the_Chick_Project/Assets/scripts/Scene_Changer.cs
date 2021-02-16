using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Scene_Changer : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("game");
    }

    public void LoadHome()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("home");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
