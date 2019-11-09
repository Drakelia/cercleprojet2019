using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerporte : MonoBehaviour
{
    public GameObject porte;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            porte.GetComponent<PorteScriptZ>().bougerPorte = true;
        }
    }
}
