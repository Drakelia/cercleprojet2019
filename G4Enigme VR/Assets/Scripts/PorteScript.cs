using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteScript : MonoBehaviour
{
    private float timer = 0;

    public bool versLeHaut;

    public float timerToMove;

    public float positionZToStop;

    public float porteEntreSpeed;

    private bool bougerPorte = false;

    public BoxCollider boxCollider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (versLeHaut)
        {
            if (boxCollider != null)
            {
                if (bougerPorte && transform.localPosition.z < positionZToStop)
                {
                    MovePorte();
                }
            }
            else
            {
                if (timer > timerToMove && transform.localPosition.z < positionZToStop)
                {
                    MovePorte();
                }
            }
        }
        else
        {
            if (boxCollider != null)
            {
                if (bougerPorte && transform.localPosition.z > positionZToStop)
                {
                    MovePorte();
                }
            }
            else
            {
                if (timer > timerToMove && transform.localPosition.z > positionZToStop)
                {
                    MovePorte();
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            bougerPorte = true;
        }
    }

    void MovePorte()
    {
        transform.Translate(0, 0, porteEntreSpeed * Time.deltaTime);
    }
}
