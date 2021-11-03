using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic; // ここコピペ

public class PlayerHitCheck : MonoBehaviour
{
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    public GameObject ItemGetEffect;
    private bool hit;
    private int Hp;
    private SpriteRenderer renderer;

    // Use this for initialization
    void Start()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();

        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ

        Hp = 6;
    }
   public void SetHp(int h)
    {
        Hp = h;
    }

    public int GetPlayerHp() { return Hp; }

    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            float level = Mathf.Abs(Mathf.Sin(Time.time * 30));
            renderer.color = new Color(1f, 1f, 1f, level);
        }
        // コルーチン開始
        StartCoroutine("WaitForIt");
    }
    IEnumerator WaitForIt()
    {
        // 1秒間処理を止める
        yield return new WaitForSeconds(1);

        // １秒後ダメージフラグをfalseにして点滅を戻す
        hit = false;
        renderer.color = new Color(1f, 1f, 1f, 1f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //アイテムに触れたとき
        if (collision.tag == "Item")
        {
            audioSource.PlayOneShot(audioClip[0]);  // ここコピペ
            GameObject Obj = Instantiate(ItemGetEffect, transform.position, Quaternion.identity) as GameObject;
            Destroy(Obj, 0.1f);
            Debug.Log("Hit Item");

        }
        
        //敵に触れたとき
        if (collision.gameObject.tag == "Enemy")
        {
            hit = true;
            Debug.Log("Hit Enemy");
            GameObject.Find("Sys").GetComponent<baibu>().SetVibration( 0.1f, 1f );
            GameObject shake = GameObject.Find("Main Camera");
            bool flg = shake.GetComponent<ShakeCamera>().GetShakeFlg();
            bool flg2 = shake.GetComponent<BulletShake>().GetShakeFlg();
            if (!flg && !flg2) shake.GetComponent<ShakeCamera>().CatchShake();

        }
        else
        {
            hit = false;
        }

        if(hit)
        {
            Hp--;
        }

    }
}
