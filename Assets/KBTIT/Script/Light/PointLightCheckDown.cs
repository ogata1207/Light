using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightCheckDown : MonoBehaviour {

    public Light lighthit;
    private CircleCollider2D col;
    public float MaxRange;
    public float MaxIntensity;

    GameObject lc;
    // bool TimerFlg;
    int Timer;
    // Use this for initialization
    void Start()
    {
        lc = GameObject.Find("StarDown");
        lighthit = GetComponent<Light>();
        col = GetComponent<CircleCollider2D>();
        MaxRange = 5.5f;
        MaxIntensity = 20.0f;
        // TimerFlg = false;
        Timer = 0;
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "LightShot") col.radius = 1.4f;
        //// レイヤー名を取得
        //string layerName = LayerMask.LayerToName(c.gameObject.layer);

        //// レイヤー名がライト弾以外の時は何も行わない
        //// ライト弾が当たったら星が光る
        //if (layerName != "LightShot") return;

        //// 光る範囲を拡大
        //lighthit.range = MaxRange;

        //// 光の強さを変える
        //lighthit.intensity = MaxIntensity;

        //if (lighthit.range <= MaxRange)
        //{
        //    lighthit.range = MaxRange;
        //}
        //if (lighthit.intensity <= MaxIntensity)
        //{
        //    lighthit.intensity = MaxIntensity;
        //}
        //lc.GetComponent<LightChekera>().TimerFlg = true;
        //// 弾の削除
        //Destroy(c.gameObject);
    }

    void Update()
    {

        if (lighthit.range >= 5.5f)
        {
            Timer++;
            if (Timer > 60 * 10)
            {
                lighthit.range = 5.0f;
                lighthit.intensity = 19.0f;
                col.radius = 1.3f;
                Timer = 0;
            }
        }
        else if (lighthit.range >= 5.0f)
        {
            Timer++;
            if (Timer > 90 * 10)
            {
                lighthit.range = 4.5f;
                lighthit.intensity = 17.0f;
                col.radius = 1.2f;
                Timer = 0;
            }
        }
        else if (lighthit.range >= 4.5f)
        {
            Timer++;
            if (Timer > 120 * 10)
            {
                lighthit.range = 4.0f;
                lighthit.intensity = 15.0f;
                col.radius = 1.0f;
                Timer = 0;
            }
        }
        else if (lighthit.range >= 4.0f)
        {
            Timer++;
            if (Timer > 150 * 10)
            {
                lighthit.range = 3.5f;
                lighthit.intensity = 13.0f;
                col.radius = 0.8f;
                Timer = 0;
            }
        }

        else if (lighthit.range >= 3.5f)
        {
            Timer++;
            if (Timer > 180 * 10)
            {
                lighthit.range = 3.0f;
                lighthit.intensity = 10.0f;
                col.radius = 0.6f;
                Timer = 0;
            }
        }
        else if (lighthit.range >= 3.0f)
        {
            Timer++;
            if (Timer > 210 * 10)
            {
                lighthit.range = 2.9f;
                lighthit.intensity = 9.0f;
                col.radius = 0.4f;
                Timer = 0;
            }
        }

        else if (lighthit.range >= 2.9f)
        {
            Timer++;
            if (Timer > 240 * 10)
            {
                lighthit.range = 2.7f;
                lighthit.intensity = 7.0f;
                col.radius = 0.0f;
                Timer = 0;
                //lc.GetComponent<LightCheckUp>().TimerFlg = false;
            }
        }
        //if (lc.GetComponent<LightCheckDown>().TimerFlg)
        //{
        //    col.radius = 1.4f;
        //    Timer++;
        //    // 一段階目
        //    if (Timer > 30 * 10)
        //    {
        //        lighthit.range = 5.5f;
        //        lighthit.intensity = 20.0f;
        //        col.radius = 1.4f;

        //        // 二段階目
        //        if (Timer > 60 * 10)
        //        {
        //            lighthit.range = 5.0f;
        //            lighthit.intensity = 19.0f;
        //            col.radius = 1.3f;

        //            // 三段階目
        //            if (Timer > 90 * 10)
        //            {
        //                lighthit.range = 4.5f;
        //                lighthit.intensity = 17.0f;
        //                col.radius = 1.2f;

        //                // 四段階目
        //                if (Timer > 120 * 10)
        //                {
        //                    lighthit.range = 4.0f;
        //                    lighthit.intensity = 15.0f;
        //                    col.radius = 1.0f;
        //                    // 五段階目
        //                    if (Timer > 150 * 10)
        //                    {
        //                        lighthit.range = 3.5f;
        //                        lighthit.intensity = 13.0f;
        //                        col.radius = 0.8f;

        //                        // 六段階目
        //                        if (Timer > 180 * 10)
        //                        {
        //                            lighthit.range = 3.0f;
        //                            lighthit.intensity = 10.0f;
        //                            col.radius = 0.6f;

        //                            // 七段階目
        //                            if (Timer > 210 * 10)
        //                            {
        //                                lighthit.range = 2.9f;
        //                                lighthit.intensity = 9.0f;
        //                                col.radius = 0.4f;

        //                                // ｵﾜﾀ (^0^)/
        //                                if (Timer > 240 * 10)
        //                                {
        //                                    lighthit.range = 2.7f;
        //                                    lighthit.intensity = 7.0f;
        //                                    col.radius = 0.0f;
        //                                    Timer = 0;
        //                                    lc.GetComponent<LightCheckDown>().TimerFlg = false;
        //                                }
        //                            }

        //                        }
        //                    }
        //                }
        //            }

        //        }
        //    }
        //}


    }
}
