using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical : MonoBehaviour
{
    float timeLeft, hDep;
    public GameObject door;
    public GameObject door1;
    public GameObject door3;

    private void Start()
    {
        timeLeft = 2;
        //door = GameObject.Find("moveBlock");
        hDep = door.transform.position.y;
    }
    void Update()
    {
        float angle = transform.eulerAngles.z;
        print(angle);
        if(angle>359 || angle < 1) {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0) {
                print(1);
                door.GetComponent<PorteScriptZ>().bougerPorte = true;
                door1.GetComponent<PorteScriptZ>().bougerPorte = true;
                door3.GetComponent<PorteScriptZ>().bougerPorte = true;
            }
        }else {
            timeLeft = 3;        
        }
    }

}
