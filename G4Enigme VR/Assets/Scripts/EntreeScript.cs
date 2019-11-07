using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntreeScript : MonoBehaviour
{
    private float timer = 0;

    public GameObject porteEntree;

    public GameObject porteSuivante;

    public float porteEntreSpeed = -1.2f;
    public float porteSuivanteSpeed = -1.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer > 5 && porteEntree.transform.localPosition.z > -3.36)
        {
            MovePorte();
        }


    }

    void MovePorte()
    {
        porteEntree.transform.Translate(0, 0, porteEntreSpeed * Time.deltaTime);
    }
}
