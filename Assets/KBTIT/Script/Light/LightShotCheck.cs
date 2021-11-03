using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ライト弾Playerと当たったらライト弾消える(-_-)why?
public class LightShotCheck : MonoBehaviour {
    void Star()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            GameObject shake = GameObject.Find("Main Camera");
            bool flg = shake.GetComponent<BulletShake>().GetShakeFlg();
            bool flg2 = shake.GetComponent<ShakeCamera>().GetShakeFlg();
            if (!flg && !flg2) shake.GetComponent<BulletShake>().CatchShake();
        }


    }
}
