using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject Flash;
    public GameObject Player;

    private GameObject UseFlash = null;
    static private bool ShotFlg;        //子機用
    private float wait = 0;
    public int Interval;
    // Use this for initialization
    void Start()
    {
        //Interval = 5;
        ShotFlg = false;
        //wait = 0;
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //// 単発押し
        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    Vector3 pos = transform.position;
        //    pos.x += .5f;
        //    Instantiate(bullet, pos, transform.rotation);
        //    // ショット音を鳴らす
        //    GetComponent<AudioSource>().Play();
        //}


        // 長押し
        if (Input.GetButton("NormalShot")||Input.GetKey(KeyCode.Z))
        {
            if (UseFlash == null)
            {
                UseFlash = Instantiate(Flash, transform.position, transform.rotation);
            }
            wait++;
            Vector3 pos = transform.position;
            pos.x += .5f;
            //Handheld.Vibrate();
            if (wait > Interval)
            {
                Instantiate(bullet, pos, transform.rotation);
                // ショット音を鳴らす
                GetComponent<AudioSource>().Play();
                wait = 0;
            }
        }

        if (Input.GetButtonUp("NormalShot")||Player.GetComponent<PlayerHitCheck>().GetPlayerHp()==0)
        {
            Destroy(UseFlash);
            UseFlash = null;
        }
    }
}
