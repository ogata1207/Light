using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSound : MonoBehaviour {
    public AudioClip BulletSound;
    private AudioSource audioSource;
    private bool BulletSoundPlay = false;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            BulletSoundPlay = false;
            if (BulletSoundPlay == false)
            {
                BulletSoundPlay = true;
                audioSource.PlayOneShot(BulletSound);
            }
        }
    }
}
