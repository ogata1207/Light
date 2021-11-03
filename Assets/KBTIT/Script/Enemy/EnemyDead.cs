using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic; // ここコピペ

public class EnemyDead : MonoBehaviour
{
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    public GameObject EffectObj;
    public GameObject HitEffect;
    public GameObject item;
    public int Hp;
    private bool DeadFlg;
    private Status status;
    private ScoreScript Sc;
    public bool InLight = false;   //ライトの中かどうか
    public GameObject ScoreEffect;

    public int point = 100;
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ

        DeadFlg = false;
        status = GetComponent<Status>();
        Sc = GetComponent<ScoreScript>();

    }

    void Update()
    {
        if (InLight == true)
        {
            status.SetDefPower(0);
        }
        else if (InLight == false)
        {
            status.SetDefPower(100);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (DeadFlg) return;

        if (collision.gameObject.tag == "bullet")
        {
            if (InLight)
            {
                GameObject hoge = Instantiate(HitEffect, transform.position, transform.rotation);
                Destroy(hoge, 0.3f);
            }
            Status ps = GameObject.FindWithTag("Player").GetComponent<Status>();
            status.DamageProc(ps.GetAtkPower(), status.GetDefPower());
            Destroy(collision.gameObject);
            Debug.Log(status.GetHealth());
            if (status.GetHealth() < 0)
            {
                FindObjectOfType<ScoreScript>().AddPoint(point);
                Destroy(gameObject);
                // 死亡エフェクト再生
                GameObject Obj = Instantiate(EffectObj, transform.position, Quaternion.identity) as GameObject;
                Destroy(Obj, 0.49f);
                GameObject ef = Instantiate(ScoreEffect, transform.position, Quaternion.identity) as GameObject;
                Destroy(ef, 0.5f);
                // PowerUpItemGeneration(訳:パワーアップアイテム生成)

                Instantiate(item, transform.position, transform.rotation);

            }

            if (collision.gameObject.tag == "bullet")
            {
                audioSource.PlayOneShot(audioClip[0]);  // ここコピペ
            }
            if (collision.gameObject.tag == "bullet" && InLight)
            {
                audioSource.PlayOneShot(audioClip[1]);  // ここコピペ
            }
        }


    }
}
