using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ControllerScript : MonoBehaviour
{
    public SteamVR_Action_Vector2 touchPad;
    public float speed;
    public Camera camera;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 axis = touchPad.axis;
        transform.position += (camera.transform.right * axis.x * speed + camera.transform.forward * axis.y * speed);
    }
}
