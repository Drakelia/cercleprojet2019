using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical : MonoBehaviour
{
    float timeLeft, hDep;
    public GameObject door;
    public GameObject door1;
    public GameObject door2;

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
                door.GetComponent<PorteScriptY>().bougerPorte = true;
                door1.GetComponent<PorteScriptY>().bougerPorte = true;
                door2.GetComponent<PorteScriptY>().bougerPorte = true;
            }
        }else {
            timeLeft = 3;        
        }
    }

}
