using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic; // ここコピペ

public class LightCheckUp : MonoBehaviour
{
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    GameObject lp;
    public bool TimerFlg;

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ

        lp = GameObject.Find("StarLightUp");
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
                lp.GetComponent<PointLightCheckUp>().lighthit.range = lp.GetComponent<PointLightCheckUp>().MaxRange;

                // 光の強さを変える
                lp.GetComponent<PointLightCheckUp>().lighthit.intensity = lp.GetComponent<PointLightCheckUp>().MaxIntensity;


                //if (lp.GetComponent<PointLightCheckUp>().lighthit.range <= lp.GetComponent<PointLightCheckUp>().MaxRange)
                //{
                //    lp.GetComponent<PointLightCheckUp>().lighthit.range = lp.GetComponent<PointLightCheckUp>().MaxRange;
                //}
                //if (lp.GetComponent<PointLightCheckUp>().lighthit.intensity <= lp.GetComponent<PointLightCheckUp>().MaxIntensity)
                //{
                //    lp.GetComponent<PointLightCheckUp>().lighthit.intensity = lp.GetComponent<PointLightCheckUp>().MaxIntensity;
                //}
                TimerFlg = true;
            }

        }
        Destroy(c.gameObject);
    }
}
