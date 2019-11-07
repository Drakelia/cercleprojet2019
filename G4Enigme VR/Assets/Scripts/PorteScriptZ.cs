using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteScriptZ : MonoBehaviour
{
    private float timer = 0;
    private bool soundPlayed = false;
    private AudioSource audioSource;

    public bool versLeHaut;
    public float timerToMove;
    public float positionZToStop;
    public float porteEntreSpeed;
    public bool bougerPorte = false;
    public BoxCollider boxCollider;
    public bool useTimer = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (versLeHaut)
        {
            if (!useTimer)
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
            if (!useTimer)
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
        if (!soundPlayed)
        {
            audioSource.Play();
            soundPlayed = true;
        }
        transform.Translate(0, 0, porteEntreSpeed * Time.deltaTime);
    }
}
