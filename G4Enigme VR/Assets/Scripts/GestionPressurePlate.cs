using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPressurePlate : MonoBehaviour
{
    public int l;
    public int h;
    public int value;
    bool trigger;
    GameObject objScript;
    ScriptSalle scriptSalle;

    // Start is called before the first frame update
    void Start()
    {
        objScript = GameObject.Find("ScriptSalle");
        scriptSalle = objScript.GetComponent<ScriptSalle>();
        trigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!trigger)
        {
            scriptSalle.trigger(h, l, value);
        } 
    }

    public void enfoncer()
    {
        transform.Translate(0, 0, -0.2f);
        trigger = true;
    }
    public void relever()
    {
        transform.Translate(0, 0, 0.2f);
        trigger = false;
    }
}
