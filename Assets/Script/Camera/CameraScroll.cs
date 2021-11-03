using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour {

    public float Power = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 Pos = GameObject.Find("Main Camera").transform.position;
        Pos.x += Power;

        GameObject.Find("Main Camera").transform.position = Pos;
		
	}
}
