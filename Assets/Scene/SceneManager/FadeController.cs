using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeController : MonoBehaviour {

    //フェード速度
    float fadespeed = 0.01f;
    //点滅用
    public float C_R, C_G, C_B, C_A;

   
    public bool isFadeOut = false;
    public bool isFadeIn = false;
    //シーン切り替えフラグ(外部から拾う)
    public bool SceneFlg = false;
    Image fadeImage;
	void Start () {
        fadeImage = GetComponent<Image>();
        C_R = fadeImage.color.r;
        C_G = fadeImage.color.g;
        C_B = fadeImage.color.b;
        C_A = fadeImage.color.a;
        
    }

    void Update () {
        if (isFadeIn)
        {
            StartFadeIn();
        }
        if (isFadeOut)
        {
            StartFadeOut();
        }
       
        
    }
    public void StartFadeIn()
    {
        C_A -= fadespeed;
        SetAlpha();
        if (C_A <= 0)
        {
            isFadeIn = false;
            fadeImage.enabled = false;
        }
    }
    public void StartFadeOut()
    {
        fadeImage.enabled = true;
        C_A += fadespeed;
        SetAlpha();
        if (C_A >= 1)
        {
            SceneFlg = true;
            isFadeOut = false;
        }
    }
    void SetAlpha()
    {
        fadeImage.color = new Color(C_R, C_G, C_B, C_A);
    }


   
}
