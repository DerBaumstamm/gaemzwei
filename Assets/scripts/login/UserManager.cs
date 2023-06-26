using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using UnityEngine;

public static class UserManager
{
    public static readonly string userdata = Application.dataPath + @"\Userdata.txt";
    public static User currentUser;
    private static User u;
    public static List<User> userlist = new List<User>();

    public static void createUser(string Username, string Password)
    {
        u = new User(Username, Password, Convert.ToString(0.0F));
        userlist.Add(u);
        currentUser = u;
        saveFile();
    }

    public static bool checkLogin(string Username, string Password)
    {
        foreach (User user in userlist)
        {
            if (Username == user.Username && Password == user.Password)
            {
                currentUser = user;
                return true;
            }
        }
        return false;
    }

    public static void loadFile()
    {
        if (File.Exists(userdata) == false)
        {
            StreamWriter sw = new StreamWriter(userdata);
            sw.Write("");
            sw.Flush();
            sw.Close();
            sw.Dispose();
        }

        List<string> data = File.ReadAllLines(userdata).ToList();
        foreach (string s in data.ToList())
        {
            List<string> decoded = s.Split('|').ToList();
            string username = decoded.ElementAt(0);
            string password = decoded.ElementAt(1);
            string highscore = decoded.ElementAt(2);
            userlist.Add(new User(username, password, highscore));
        }
    }

    public static void updateScore(string newHighscore = "0")
    {
        foreach (User user in userlist)
        {
            if (user == currentUser)
            {
                user.Highscore = newHighscore;
            }
        }
        saveFile();
    }

    public static void saveFile()
    {
        if (File.Exists(userdata) == false)
        {
            File.Create(userdata);
        }

        List<string> encoded = new List<string>();
        foreach (User u in userlist)
        {
            encoded.Add(u.Username + "|" + u.Password + "|" + u.Highscore);
        }
        File.WriteAllLines(userdata, encoded);
    }

}
