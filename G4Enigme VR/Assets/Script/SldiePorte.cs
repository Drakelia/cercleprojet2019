using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SldiePorte : MonoBehaviour
{

    private Animator _animator;
    // Start is called before the first frame update
    bool Pot1;
    bool Pot2;
    bool Pot3;
    bool Pot4;
    bool PorteOuverte = false;
    public float speed;



    int fps = 0;

    void Start()
    {
  
        _animator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {


 

        float posXPos1 = GameObject.Find("Pot1").transform.position.x;
        float posYPos1 = GameObject.Find("Pot1").transform.position.z;
        float posXPos2 = GameObject.Find("Pot2").transform.position.x;
        float posYPos2 = GameObject.Find("Pot2").transform.position.z;
        float posXPos3 = GameObject.Find("Pot3").transform.position.x;
        float posYPos3 = GameObject.Find("Pot3").transform.position.z;
        float posXPos4 = GameObject.Find("Pot4").transform.position.x;
        float posYPos4 = GameObject.Find("Pot4").transform.position.z;

        if (posXPos1 > 295 && posXPos1 < 299 && posYPos1 > 45 && posYPos1 < 47)
        {
            Pot1 = true;
            print("pot1 ok");
        }


        if (posXPos2 > 295 && posXPos2 < 300 && posYPos2 > 53 && posYPos2 < 56)
        {
            Pot2 = true;
            print("pot2 ok");
        }
        

        if (posXPos3 < 310 && posXPos3 > 306 && posYPos3 > 53 && posYPos3 < 56)
        {
            Pot3 = true;
            print("pot3 ok");
        }


        if (posXPos4 > 306 && posXPos4 < 309 && posYPos4 > 44 && posYPos4 < 48)
        {
            Pot4 = true;
            print("pot4 ok");
        }


        if (Pot1 && Pot2 && Pot3 && Pot4 /*&& fps <= 330*/ )
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
            /*           fps = fps + 1;
                       _animator.gameObject.GetComponent<Animator>().enabled = true;
                       _animator.SetBool("portes", true);
                       print(fps);
                   }
                    else if (Pot1 && Pot2 && Pot3 && Pot4 && fps == 331 )
                     {
                         fps = fps + 1;
                         _animator.gameObject.GetComponent<Animator>().enabled = false;
                         _animator.SetBool("portes", false);
                         print(fps);
                     }
            */
        }
    }

