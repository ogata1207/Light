using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic; // ここコピペ

public class FontAlpha : MonoBehaviour
{
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    private float Step = 0.30f;
    public bool StepFlg = false;
    public int Step_timer;

    GameObject Push;
    float toColor;
    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ
        this.Push = GameObject.Find("Push");
        this.Push.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        Step_timer = 120;
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.U))
        //{
        //    audioSource.PlayOneShot(audioClip[0]);  // ここコピペ
        //}

        if (StepFlg)
        {
            toColor = this.Push.GetComponent<SpriteRenderer>().color.a;
            if (toColor < 0 || toColor > 1)
            {
                Step = -Step;
            }
            this.Push.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, toColor + Step);
            Step_timer--;
        }

    }
    public void Flash_Flg()
    {
        StepFlg = true;
    }
}
