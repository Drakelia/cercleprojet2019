using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime;

public class timerScriptt : MonoBehaviour
{

    private int timer = 60 * 15;
    private double TimerAffiche;
    int timerSeconde;
    string TimerAfficheString;
    private void Start()
    {
        if (PlayerPrefs.GetInt("Time") == 9999 || PlayerPrefs.GetInt("Time") <= 0) {
            print("ok");
        } else {
            timer = PlayerPrefs.GetInt("Time");
        } 

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
        PlayerPrefs.SetInt("Time", 900);
        TimerAffiche = (int) timer / 60; // nombre virgule chelou
        timerSeconde = timer % 60;
        print(TimerAffiche);


        //Debug.Log(timer);
        gameObject.GetComponent<Text>().text = TimerAffiche.ToString() + ":" + timerSeconde.ToString() ;

        if (timer == 0) return;

        StartCoroutine(toto());
           
    }

}
