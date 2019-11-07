using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public GameObject gameManager;
    public void Play()
    {
        gameManager.GetComponent<SceneManagerScript>().NextScene();
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
