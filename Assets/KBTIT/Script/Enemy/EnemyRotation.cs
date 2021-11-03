using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour {

    private Vector3 pos ;
    public float 円の大きさ;
    public float 回転スピード;
    public float 左への移動スピード;
    // Use this for initialization
    void Start () {
        //Move(transform.right * -1);
        pos = transform.position;
    }
    //public void Move(Vector2 direction)
    //{
    //    GetComponent<Rigidbody2D>().velocity = direction * 左への移動スピード;
    //}

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(pos.x + Mathf.Cos(回転スピード * Time.time - Mathf.PI / 2) * 円の大きさ,
                               pos.y + Mathf.Sin(回転スピード * Time.time + Mathf.PI / 2) * 円の大きさ,
                               0);
        pos.x -= 左への移動スピード;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }

    }
}
