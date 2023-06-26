using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void quitButton()
    {
        Application.Quit();
    }

    public void backToMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
