using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kari : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 Pos = GameObject.FindWithTag("Player").transform.position;
        transform.position = Pos;

	}
}
