using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMain : MonoBehaviour
{

    private bool flg = false;
    public int ChangeTimer = 120;
    public bool MoveResult = false;

    public GameObject fade;
    FadeController script;
    Blinker blin;
    GameObject Player;
    // Use this for initialization

    void Awake()
    {
        
    }
    void Start()
    {
        fade.SetActive(true);
        fade = GameObject.Find("fade");
        
        Player = GameObject.Find("Player");
        script = fade.GetComponent<FadeController>();
        script.StartFadeIn();
        script.isFadeIn = true;
        MoveResult = false;
        //ChangeTimer = 60 * 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (flg == false)
        {
            script.isFadeOut = false;
            script.StartFadeIn();
            script.isFadeIn = true;
            flg = true;

        }

        if (MoveResult) LoadResult();
        if (Input.GetKey(KeyCode.I)) Time.timeScale = 0;
        if (Player.GetComponent<PlayerHitCheck>().GetPlayerHp() == 0) MoveResult = true;
    }

    void LoadResult()
    {
        ChangeTimer--;
        script.isFadeOut = true;
        script.StartFadeOut();
        if (ChangeTimer <= 0)
        {
            if (script.SceneFlg)
            {
                Loading.SceneName = "Result";
                SceneManager.LoadScene("LoadScene", LoadSceneMode.Single);
            }
        }
    }
}
