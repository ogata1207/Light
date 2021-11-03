using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = GameObject.FindWithTag("Player").transform.position;
        pos.x += 1.0f;

        transform.position = pos;
	}
}
