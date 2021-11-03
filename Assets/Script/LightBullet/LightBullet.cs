using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBullet : MonoBehaviour {
    public float speed = 0.1f;
 
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
}
