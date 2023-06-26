using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public static Timer Instance;

    [SerializeField] private TMP_Text timer;
    private float time = 0;
    private bool timerActive = false;

    [SerializeField]
    private string sceneName = "EndScreen" ;

    private void Start()
    {        
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

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
        switchScene();
    }

    public void switchScene()
    {
        gameObject.GetComponent<TMP_Text>().enabled = false;
        SceneManager.LoadScene(sceneName);
    }

    public float getTime()
    {
        return time;
    }
}
