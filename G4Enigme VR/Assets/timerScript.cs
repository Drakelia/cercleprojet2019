using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime;

public class timerScript : MonoBehaviour
{

    private int timer;
    private double TimerAffiche;
    int timerSeconde;
    string TimerAfficheString;
    private void Start()
    {
        timer = PlayerPrefs.GetInt("Time");
        StartCoroutine(toto());
    }

    IEnumerator toto()
    {
        yield return new WaitForSeconds(1);

        SetTimer();
    }

    private void SetTimer()
    {
        timer--;
        PlayerPrefs.SetInt("Time", timer);
        TimerAffiche = (int)timer / 60; // nombre virgule chelou
        timerSeconde = timer % 60;
        print(TimerAffiche);


        //Debug.Log(timer);
        gameObject.GetComponent<Text>().text = TimerAffiche.ToString() + ":" + timerSeconde.ToString();

        if (timer == 0) return;
        StartCoroutine(toto());

    }

}
