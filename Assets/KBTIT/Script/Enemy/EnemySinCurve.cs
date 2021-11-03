using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySinCurve : MonoBehaviour
{

    public float angle = 0;
    public float 振り幅 = 3f;        // 振り幅
    public float 上下のスピード = 0.05f;    // 上下のスピード
    public float 左への移動スピード;


    void Start()
    {
        Move(transform.right * -1);
    }


    void Update()
    {
        Vector3 Pos = transform.position;
        Pos.z = -1.191769f;
        Vector2 v = transform.position;
        v.y = Mathf.Sin(angle) * 振り幅;
        angle += 上下のスピード;
        transform.position = v;
    }

    public void Move(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * 左への移動スピード;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }

    }
}
