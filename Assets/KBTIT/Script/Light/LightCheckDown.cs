using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic; // ここコピペ

public class LightCheckDown : MonoBehaviour {

    GameObject lp;
    public bool TimerFlg;
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ

        lp = GameObject.Find("StarLightDown");
        //TimerFlg = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        {// レイヤー名を取得
            string layerName = LayerMask.LayerToName(c.gameObject.layer);

            // レイヤー名がライト弾以外の時は何も行わない
            // ライト弾が当たったら星が光る
            if (layerName != "LightShot") return;

            if (layerName == "LightShot")
            {
                audioSource.PlayOneShot(audioClip[0]);  // ここコピペ

                // 光る範囲を拡大
                lp.GetComponent<PointLightCheckDown>().lighthit.range = lp.GetComponent<PointLightCheckDown>().MaxRange;

                // 光の強さを変える
                lp.GetComponent<PointLightCheckDown>().lighthit.intensity = lp.GetComponent<PointLightCheckDown>().MaxIntensity;

                if (lp.GetComponent<PointLightCheckDown>().lighthit.range <= lp.GetComponent<PointLightCheckDown>().MaxRange)
                {
                    lp.GetComponent<PointLightCheckDown>().lighthit.range = lp.GetComponent<PointLightCheckDown>().MaxRange;
                }
                if (lp.GetComponent<PointLightCheckDown>().lighthit.intensity <= lp.GetComponent<PointLightCheckDown>().MaxIntensity)
                {
                    lp.GetComponent<PointLightCheckDown>().lighthit.intensity = lp.GetComponent<PointLightCheckDown>().MaxIntensity;
                }


                TimerFlg = true;
            }
        }
        Destroy(c.gameObject);

    }
}
