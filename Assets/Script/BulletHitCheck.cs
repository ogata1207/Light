using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHitCheck : MonoBehaviour {

    public bool BulletShakeFlg;
	void Start () {
    }
   public bool GetFlg() { return BulletShakeFlg; }
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
           // Destroy(collision.gameObject);zzz
            Destroy(gameObject);
            GameObject shake = GameObject.Find("Main Camera");
            bool flg = shake.GetComponent<BulletShake>().GetShakeFlg();
            bool flg2 = shake.GetComponent<ShakeCamera>().GetShakeFlg();
            if (!flg && !flg2 ) shake.GetComponent<BulletShake>().CatchShake();
            BulletShakeFlg = true;
        }
        else
        {
            BulletShakeFlg = false;
        }
    }
}
