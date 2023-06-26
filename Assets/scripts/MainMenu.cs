using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TMP_Text currentUser;
    public TMP_Text highscore;
    public TMP_Text header;

    void Start()
    {
        currentUser.text ="Current User: " + UserManager.currentUser.Username;
        highscore.text = "Your Highscore: " + UserManager.currentUser.Highscore;
    }

    private void Update()
    {
        header.transform.Rotate(Vector3.one * 100 * Time.deltaTime);
    }

    public void start()
    {
        SceneManager.LoadScene("Game");
    }
    public void quit()
    {
        Application.Quit();
    }
}
