using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical : MonoBehaviour
{
    float timeLeft, hDep;
    GameObject door;

    private void Start()
    {
        timeLeft = 3;
        door = GameObject.Find("moveBlock");
        hDep = door.transform.position.y;
    }
    void Update()
    {
        float angle = transform.eulerAngles.z;
        print(angle);
        if(angle>359 || angle < 1) {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0) { 
                door.transform.Translate(0, Time.deltaTime, 0);
            }
        }else {
            timeLeft = 3;
            if(door.transform.position.y > hDep) {
                door.transform.Translate(0, -Time.deltaTime, 0);
            }
           
        }
    }

}
