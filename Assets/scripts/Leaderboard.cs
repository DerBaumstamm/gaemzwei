using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Drawing;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public partial class Leaderboard : MonoBehaviour
{
    List<User> users = new List<User>();
    public TMP_Text rtbName;
    public TMP_Text rtbScore;
    public TMP_Text rtbPlace;
    public void Start()
    {
        if (Convert.ToDouble(UserManager.currentUser.Highscore) > Convert.ToDouble(Timer.Instance.getTime()) || Convert.ToDouble(UserManager.currentUser.Highscore) == 0)
        {
            UserManager.updateScore(Timer.Instance.getTime().ToString("0.00"));
        }

        rtbName.text = "";
        users = UserManager.userlist;
        sortLeaderboard();

        if (users.Count > 15)
        {
            users.RemoveRange(15, users.Count - 15);
        }

        for (int i = 0; i < users.Count; i++)
        {
            rtbName.text += users[i].Username + "\n";
            rtbScore.text += " " + users[i].Highscore + "\n";
            rtbPlace.text += Convert.ToString(i + 1) + ".\n";
        }
    }

    private void sortLeaderboard()
    {
        users = users.OrderBy(User => Convert.ToDouble(User.Highscore)).ToList();
    }  
}
