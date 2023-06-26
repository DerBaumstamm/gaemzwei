using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public partial class Login : MonoBehaviour
{
    public TMP_InputField tbUsername;
    public TMP_InputField tbPassword;
    public TMP_Text lbError;

    public void Start()
    {
        UserManager.loadFile();
    }

    public void rbLogin_Click()
    {
        if (tbUsername.text.Length <= 0)
        {
            lbError.text = "Enter username!";
            return;
        }
        if (tbPassword.text.Length <= 0)
        {
            lbError.text = "Enter password!";
        }
        if (UserManager.checkLogin(tbUsername.text, tbPassword.text))
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            lbError.text = "Username or password is incorrect";
        }
    }

    public void rbSignup_Click()
    {
        SceneManager.LoadScene("Signup");
    }
}
