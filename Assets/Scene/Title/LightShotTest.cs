using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightShotTest : MonoBehaviour {
    public GameObject bullet;

    int Wait = 0;
    // Use this for initialization
    void Start()
    {
        //Interval = 5;
        //wait = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // 単発押し
        if (Input.GetButtonDown("NormalShot"))
        {
    
                Vector3 pos = transform.position;
                pos.x += .5f;
                Instantiate(bullet, pos, transform.rotation);
            
        }
    }
}
