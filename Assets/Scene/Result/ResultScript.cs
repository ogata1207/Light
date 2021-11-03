using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultScript : MonoBehaviour
{

    private bool flg = false;
    public int ChangeTimer = 120;
    public bool MoveTitle = false;

    GameObject fade;
    FadeController script;
    Blinker blin;


    // Use this for initialization
    void Start () {

        fade = GameObject.Find("fade");
        script = fade.GetComponent<FadeController>();
        script.StartFadeIn();
        script.isFadeIn = true;
        MoveTitle = false;
        ChangeTimer = 60 * 2;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (flg == false)
        {
            script.isFadeOut = false;
            script.StartFadeIn();
            script.isFadeIn = true;
            flg = true;
        }


            if (MoveTitle) LoadTitle();
            if (Input.GetButtonDown("Start")) MoveTitle = true;
    }

   private void LoadTitle()
   {
            ChangeTimer--;
            script.isFadeOut = true;
            script.StartFadeOut();
            if (ChangeTimer <= 0)
            {
                SceneManager.LoadScene("Title");
            }
    }
}