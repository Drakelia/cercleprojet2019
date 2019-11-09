using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DallePress : MonoBehaviour
{
    public GameObject Zone;
    private Color red;
    //private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //-------------------------------------------------
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Player")
        {
            Zone.GetComponent<Renderer>().material.color = Color.red;
            print("alo");
        }
    }
}
