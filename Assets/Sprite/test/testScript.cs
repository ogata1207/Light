using UnityEngine;
using System.Collections;

public class testScript : MonoBehaviour
{
    public float ScrollSpeed = 1.0f;
    public GameObject prefab;
    IEnumerator Scroll()
    {

        Vector3 pos = transform.position;
        pos.x -= ScrollSpeed * 0.1f;
        transform.position = pos;
        if (transform.position.x <= -18.77f)
        {
            //pos.x = 16.79f;
            //transform.position = pos; /* new Vector3(16.79f, 0, 0);*/
            Instantiate(prefab);
            Destroy(gameObject);
        }

        yield return null;

    }
    void Update()
    {
        StartCoroutine("Scroll");
        //    //transform.Translate(-0.05f * ScrollSpeed, 0, 0);
        //    if (transform.position.x <= -18.77f)
        //    {
        //        transform.position = new Vector3(16.79f, 0, 0);
        //    }
    }
}