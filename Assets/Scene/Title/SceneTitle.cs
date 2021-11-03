using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTitle : MonoBehaviour
{
    GameObject fade;
    FadeController script;
    FontAlpha blin;
    GameObject Push;

    // Use this for initialization
    void Start()
    {
        fade = GameObject.Find("fade");
        script = fade.GetComponent<FadeController>();
        Push = GameObject.Find("Push");
        blin = Push.GetComponent<FontAlpha>();
        script.StartFadeIn();
        script.isFadeIn = true;
        ScoreScript.score = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Start"))
        {

            blin.Flash_Flg();
            script.StartFadeOut();
            script.isFadeOut = true;
        }
        if (blin.Step_timer <= 0)
        {
            script.isFadeOut = true;
        }

        if (script.SceneFlg)
        {
            Loading.SceneName = "SceneMain";
            SceneManager.LoadScene("LoadScene", LoadSceneMode.Single);
        }
    }
}