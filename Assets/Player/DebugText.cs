using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugText : MonoBehaviour {

    public Text text;
    private int SP = 0;  //スキルポイント

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        SP = GameObject.FindWithTag("Player").GetComponent<Status>().GetSkillPoint();
        this.GetComponent<Text>().text = "SkillPoint : " + SP.ToString();
    }
}
