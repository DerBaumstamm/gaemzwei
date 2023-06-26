using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public partial class SignUp : MonoBehaviour
{
    public TMP_InputField tbUsername;
    public TMP_InputField tbPassword;
    public TMP_InputField tbConfirm;
    public TMP_Text lbError;

    public void rbCreateAccount_Click()
    {
        if (tbUsername.text.Length <= 0)
        {
            lbError.text = "Enter a username!";
            return;
        }
        if (tbUsername.text.Length > 30)
        {
            lbError.text = "Username too long!";
            return;
        }
        if (tbPassword.text.Length <= 0)
        {
            lbError.text = "Enter password!";
            return;
        }
        if (tbPassword.text != tbConfirm.text)
        {
            lbError.text = "Password and confirmation don't match!";
            return;
        }

        UserManager.createUser(tbUsername.text, tbPassword.text);
        SceneManager.LoadScene("MainMenu");
    }

    public void cancel()
    {
        SceneManager.LoadScene("Login");
    }
}
