using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical : MonoBehaviour
{
    float timeLeft;

    private void Start()
    {
        timeLeft = 3;
    }
    void Update()
    {
        float angle = transform.eulerAngles.z;
        print(angle);
        if(angle>359.5 || angle < 0.5) {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                print("ok");
            }
        } else
        {
            timeLeft = 3;
        }
    }

}
