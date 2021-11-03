using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic; // ここコピペ

public class PlayerDead : MonoBehaviour {
    public GameObject EffectObj;
    GameObject Player;
    AudioSource audioSource;  // ここコピペ
    private int DeadTimer = 30;
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    
    // Use this for initialization
    void Start () {
        DeadTimer = 30;
        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update () {
		if(Player.GetComponent<PlayerHitCheck>().GetPlayerHp()==0)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Shot>().enabled = false;
            GetComponent<PlayerMove>().enabled = false;
            audioSource.PlayOneShot(audioClip[0]);  // ここコピペ
            //Destroy(gameObject,0.48f);
            
           
            GameObject Obj = Instantiate(EffectObj, transform.position, Quaternion.identity) as GameObject;
            Destroy(Obj, 0.49f);
            DeadTimer--;
            if(DeadTimer < 0)
            gameObject.SetActive(false);
        }
    }
}
