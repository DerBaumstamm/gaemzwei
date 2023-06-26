using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Highscore { get; set; }

    public User(string username, string password, string highscore)
    {
        Username = username;
        Password = password;
        Highscore = highscore;
    }
}
