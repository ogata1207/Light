using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtionPanelChange : MonoBehaviour {

    private SpriteRenderer Sp;
    private SpriteRenderer Sp2;
    public Sprite MAX;
    public Sprite MAX2;
    GameObject Player;
    private Skill s;
    void Start()
    {
        Sp = gameObject.GetComponent<SpriteRenderer>();
        Sp2 = GameObject.Find("OPitionPanel1").GetComponent<SpriteRenderer>();
        Player = GameObject.Find("Player");
        s = Player.GetComponent<Skill>();
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.F2))
        //{
        //    Sp.sortingOrder = 2;
        //}
        //else if (Input.GetKeyDown(KeyCode.W))
        //{
        //    Sp.sortingOrder = 0;
        //}
        int sun = s.GetKokiNum();
        if (sun >= s.子機の最大数)
        {
            Sp2.sprite = MAX2;
            Sp.sprite = MAX;
        }

        if (Player.GetComponent<Status>().GetSkillPoint() == 2)
        {
            Sp.sortingOrder = 3;
        }

        else 
        {
            Sp.sortingOrder = -2;
        }
    }
}
