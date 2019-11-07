using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class OpenFireDoor : MonoBehaviour
{
    public GameObject Brasero1;
    public GameObject Brasero2;
    public GameObject Brasero3;
    public GameObject Brasero4;
    public GameObject Brasero5;
    public GameObject Brasero6;

    public float speed;

    bool bOpen = false;

    bool played = false;

    bool isBurning1;
    bool isBurning2;
    bool isBurning3;
    bool isBurning4;
    bool isBurning5;
    bool isBurning6;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Brasero1.GetComponentInChildren<FireSource>().isBurning)
        {
            isBurning1 = true;
        }
        if (Brasero2.GetComponentInChildren<FireSource>().isBurning)
        {
            isBurning2 = true;
        }
        if (Brasero3.GetComponentInChildren<FireSource>().isBurning)
        {
            isBurning3 = true;
        }
        if (Brasero4.GetComponentInChildren<FireSource>().isBurning)
        {
            isBurning4 = true;
        }
        if (Brasero5.GetComponentInChildren<FireSource>().isBurning)
        {
            isBurning5 = true;
        }
        if (Brasero6.GetComponentInChildren<FireSource>().isBurning)
        {
            isBurning6 = true;
        }

        if(isBurning1 && isBurning2)// && isBurning3 && isBurning4 && isBurning5 && isBurning6)
        {
            bOpen = true;
            print("OPEEEEEEN");
            GetComponent<PorteScriptZ>().bougerPorte = true;
            //transform.Translate(0,0, speed * Time.deltaTime);    
        }
    }
}
