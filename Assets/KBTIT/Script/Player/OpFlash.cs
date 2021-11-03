using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpFlash : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            Vector3 pos = GameObject.FindWithTag("Option").transform.position;
            pos.x += 0.5f;

            transform.position = pos;

        }
    }
}
