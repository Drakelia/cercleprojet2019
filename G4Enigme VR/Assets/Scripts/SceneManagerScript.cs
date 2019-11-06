using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator anim;

    public string NextSceneName;

    void Start()
    {
        //StartCoroutine(Fading());
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void NextScene()
    {
        StartCoroutine(Fading());
    }

    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => anim.GetComponent<Image>().color.a == 1);
        SceneManager.LoadScene(NextSceneName);
    }

}
