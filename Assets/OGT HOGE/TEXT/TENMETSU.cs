using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TENMETSU : MonoBehaviour {

    public Text Qtext;
    float a_color;
    bool flag_G;
    Color c;
    // Use this for initialization
    void Start()
    {
        a_color = 0;
        c = Qtext.color;
    }
    // Update is called once per frame
    void Update()
    {
        //テキストの透明度を変更する
        Qtext.color = new Color(c.r, c.g, c.b, a_color);
        if (flag_G)
            a_color -= Time.deltaTime * 2;
        else
            a_color += Time.deltaTime * 2;
        if (a_color < 0)
        {
            a_color = 0;
            flag_G = false;
        }
        else if (a_color > 1)
        {
            a_color = 1;
            flag_G = true;
        }
    }
}
