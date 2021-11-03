using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLightScript : MonoBehaviour {

   public Light light;
    private int PlayerLightTimer;
    private CircleCollider2D col;
    GameObject Player;
    void Start()
    {
        light = GetComponent<Light>();
        PlayerLightTimer = 0;
        Player = GameObject.Find("Player");
        col = GameObject.Find("PlayerCir").GetComponent<CircleCollider2D>();


    }

    // Update is called once per frame
    void Update () {

        //if (Input.GetKeyDown(KeyCode.L))
        //{
        //    //light.intensity += 1.0f;
        //    light.range += 0.1f;
        //}
        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    //light.intensity += 1.0f;
        //    light.range -= 0.1f;
        //}
        // 1段階目(MAX時)
        if (light.range >= 5.0f)
        {
            col.radius = 2.0f;
            PlayerLightTimer++;
            if (PlayerLightTimer > 60*5)
            {
                light.range -= 0.5f;
                PlayerLightTimer = 0;
                col.radius = 2.0f;
            }
            //Debug.Log("1");
        }

        // 2段階目
        else if (light.range >= 4.5f)
        {
            PlayerLightTimer++;
            if (PlayerLightTimer > 60*7)
            {
                light.range -= 0.5f;
                PlayerLightTimer = 0;
                col.radius = 1.6f;
            }
        }

        // 3段階目
        else if (light.range >= 4.0f)
        {
            PlayerLightTimer++;
            if (PlayerLightTimer > 60*9)
            {
                light.range -= 0.5f;
                PlayerLightTimer = 0;
                col.radius = 1.4f;
            }
        }

        // 4段階目
        else if (light.range >= 3.5f)
        {
            PlayerLightTimer++;
            if (PlayerLightTimer > 60 * 10)
            {
                light.range -= 0.5f;
                PlayerLightTimer = 0;
                col.radius = 1.2f;
            }
        }

        // 5段階目
        else if (light.range >= 3.0f)
        {
            PlayerLightTimer++;
            if (PlayerLightTimer > 60 * 12)
            {
                light.range -= 0.5f;
                PlayerLightTimer = 0;
                col.radius = 1.0f;
            }
        }

        // ｵﾜﾀ (^0^)/
        else if (light.range >= 2.5f)
        {
            PlayerLightTimer++;
            if (PlayerLightTimer > 60 * 14)
            {
                light.range -= 0.5f;
                PlayerLightTimer = 0;
                col.radius = 0.5f;
            }
        }

    }

}
