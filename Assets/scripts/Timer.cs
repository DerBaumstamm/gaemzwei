using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    private float time = 0;
    private bool timerActive = false;

    private void Start()
    {        
        timerActive = true;
    }

    void Update()
    {               
        if (timerActive == true)
        {
            time += Time.deltaTime;
            timer.text = time.ToString("0.00");
        }
    }
    public void OnTriggerEnter(Collider collider)
    {
        timerActive = false;
    }
}
