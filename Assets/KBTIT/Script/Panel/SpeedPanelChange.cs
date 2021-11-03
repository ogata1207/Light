using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPanelChange : MonoBehaviour {

    private SpriteRenderer Sp;
    private SpriteRenderer Sp2;
    public GameObject Player;
    public Sprite MAX;
    public Sprite MAX2;
    private Skill s;
    void Start()
    {
        Sp = gameObject.GetComponent<SpriteRenderer>();
        Sp2 = GameObject.Find("speed1").GetComponent<SpriteRenderer>();
        Player = GameObject.Find("Player");
        s = Player.GetComponent<Skill>();
        
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.F1))
        //{
        //    Sp.sortingOrder = 2;
        //}
        //else if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    Sp.sortingOrder = 0;
        //}

        int sun = s.GetSpeedUpNum();
        if (sun >= s.スピードアップ最大回数)
        {
            Sp2.sprite = MAX2;
            Sp.sprite = MAX;
        }
        if (Player.GetComponent<Status>().GetSkillPoint() == 1)
        {
            Sp.sortingOrder = 3;
        }

        else 
        {
            Sp.sortingOrder = -2;
        }
    }
}