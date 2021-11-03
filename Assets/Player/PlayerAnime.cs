using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnime : MonoBehaviour {

    Animator anim;
    bool FreezeUpFlg;
    bool UpFlg;

    bool FreezeDownFlg;
    bool DownFlg;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        FreezeUpFlg = false;
        UpFlg = false;
        FreezeDownFlg = false;
        DownFlg = false;
    }
	
	void Update () {
        // Wキーが押されたらUp再生
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Up",true);
            FreezeUpFlg = true;
        }
        else
        {
            anim.SetBool("Up", false);
        }
        // Upモーション固定再生
        if (FreezeUpFlg)
        {
            anim.SetBool("FreezeUp", true);
        }
        // Wキーが離されたらモーションをUp~Waitに変える
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("FreezeUp", false);
            UpFlg = true;
        }
        if(UpFlg)
        {
            anim.SetBool("UpChange", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Down", true);
            FreezeDownFlg = true;
        }
        else
        {
            anim.SetBool("Down", false);
        }
        // Downモーション固定再生
        if (FreezeDownFlg)
        {
            anim.SetBool("FreezeDown", true);
        }
        // Wキーが離されたらモーションをUp~Waitに変える
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("FreezeDown", false);
            DownFlg = true;
        }
        if (DownFlg)
        {
            anim.SetBool("DownChange", false);
        }

    }
}
