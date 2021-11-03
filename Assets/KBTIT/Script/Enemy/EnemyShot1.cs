using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot1 : MonoBehaviour
{
    public GameObject bullet;
    private float wait;
    public float speed = 0.2f;
    // Use this for initialization
    void Start()
    {
        wait = 0;
    }

    void Update()
    {
        wait++;

        Vector3 Pos = transform.position;
        Pos.x -= speed;
        transform.position = Pos;

        if (Input.GetKeyDown(KeyCode.H))
        {
            Vector3 pos = transform.position;
            pos.x -= .5f;
            Instantiate(bullet, pos, transform.rotation);
            wait = 0;
        }
    }
}
