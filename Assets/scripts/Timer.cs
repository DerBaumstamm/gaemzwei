using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    float time = 0;

    void Update()
    {
        time += Time.deltaTime;
        timer.text = time.ToString("0.00");
    }
}
