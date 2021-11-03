using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPanelChange : MonoBehaviour {

    public SpriteRenderer Sp;
    GameObject Player;

    void Start()
    {
        Sp = gameObject.GetComponent<SpriteRenderer>();
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.F3))
        //{
        //    Sp.sortingOrder = 3;
        //}
        //else if (Input.GetKeyDown(KeyCode.E))
        //{
        //    Sp.sortingOrder = 0;
        //}


        if (Player.GetComponent<Status>().GetSkillPoint() == 3)
        {
            Sp.sortingOrder = 3;
        }

        else 
        {
            Sp.sortingOrder = -2;
        }
    }
}
