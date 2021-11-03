using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player = GameObject.FindWithTag("Player");
        Vector3 pos = player.transform.position;
        pos.x = transform.position.x;

        transform.position = pos;
	}
}
