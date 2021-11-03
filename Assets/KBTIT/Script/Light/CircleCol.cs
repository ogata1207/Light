using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCol : MonoBehaviour {

    CircleCollider2D col;
    private bool InLight = false;
    // Use this for initialization
    void Start () {

        col = GetComponent<CircleCollider2D>();
  
    }
	
	// Update is called once per frame
	void Update () {
       

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if( collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<EnemyDead>().InLight = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<EnemyDead>().InLight = false;
        }
    }
}
