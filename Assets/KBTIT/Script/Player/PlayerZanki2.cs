using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerZanki2 : MonoBehaviour {

    public SpriteRenderer sp;
    public GameObject Player;

    // Use this for initialization
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
        Player = GameObject.FindWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<PlayerHitCheck>().GetPlayerHp() == 4)
        {
            sp.sortingOrder = -2;
        }
        //else
        //{
        //    sp.sortingOrder = 2;
        //}
    }
}
