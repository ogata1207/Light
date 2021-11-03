using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 0.2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.x += speed;
        transform.position = pos;

        float len = transform.position.magnitude;

        if (len > 9)
        {
            Destroy(gameObject);
        }
    }

    //private OnTrrigerEnter2D()
}
