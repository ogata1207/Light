using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blinker : MonoBehaviour {
    private float Step = 0.30f;
    public bool StepFlg = false;
    public int Step_timer;

    GameObject Push;
    float toColor;
   // Use this for initialization
    void Start () {
        this.Push = GameObject.Find("Text");
        this.Push.GetComponent<Text>().color = new Color(0, 0, 0, 1);
        Step_timer = 120;
    }

    // Update is called once per frame
    void Update () {
        if (StepFlg)
        {
            toColor = this.Push.GetComponent<Text>().color.a;
            if (toColor < 0 || toColor > 1)
            {
                Step = -Step;
            }
            this.Push.GetComponent<Text>().color = new Color(255, 255, 255, toColor + Step);
            Step_timer--;
        }
       
    }
    public void Flash_Flg()
    {
        StepFlg = true;
    }
}
