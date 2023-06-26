using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText;

    void Start()
    {
        printTime();
    }

    public void backToMenu(string sceneName = "MainMenu")
    {
        SceneManager.LoadScene(sceneName);
    }

    private void printTime()
    {
        timeText.text = Timer.Instance.getTime().ToString("0.00");
    }
}
