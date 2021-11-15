using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float timeleftSeconds = 3f;
    public static bool TimesUp = false;
    public string GameSceneName;

    // Start is called before the first frame update
    void Start()
    {
        TimesUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        float t = timeleftSeconds -= Time.deltaTime;

        string minutes = ((int) t/60).ToString("00");
        string seconds = (t % 60).ToString("00");
        string miliseconds = ((int)(t*100f) % 100).ToString("00");

        timerText.text = minutes + ":" + seconds + ":" + miliseconds;
        
        if(timeleftSeconds <= 0)
        {
            timeleftSeconds = 0;
            timerText.text = minutes + ":" + seconds;
            TimesUp = true;
        }

    }

    void OnGUI() 
    {
        if(TimesUp == true)
            GUI.Box(new Rect(0,50,250,25), "Game Over.");
    }
}
