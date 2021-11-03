using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections.Generic; // ここコピペ

public class Item : MonoBehaviour {
 //   AudioSource audioSource;  // ここコピペ
  //  public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    void Start () {
       // audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ
    }

    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //audioSource.PlayOneShot(audioClip[0]);  // ここコピペ
        if (collision.tag == "Player")
        {
            int sp = collision.GetComponent<Status>().GetSkillPoint();
            sp++;
            collision.GetComponent<Status>().SetSkillPoint(sp);
            Destroy(gameObject);
        }
    }
}
