//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BackAlpha : MonoBehaviour {
//    float changeRed = 1.0f;
//    float changeGreen = 1.0f;
//    float changeBlue = 1.0f;
//    float chageAlpha = 0.1f;

//    int AlphaTimer;
//    void Start () {
//        AlphaTimer = 0;
//    }

//	void Update () {
//        AlphaTimer++;

//        if(AlphaTimer>10)
//        {
//            chageAlpha = 0.15f;
//            if(AlphaTimer>20/2)
//            {
//                chageAlpha = 0.2f;
//                if (AlphaTimer > 30 / 2)
//                {
//                    chageAlpha = 0.25f;
//                    if (AlphaTimer > 40 / 2)
//                    {
//                        chageAlpha = 0.3f;
//                        if (AlphaTimer > 50 / 2)
//                        {
//                            chageAlpha = 0.35f;
//                            if (AlphaTimer > 60 / 2)
//                            {
//                                chageAlpha = 0.4f;
//                                if (AlphaTimer > 70 / 2)
//                                {
//                                    chageAlpha = 0.45f;
//                                    if (AlphaTimer > 80 / 2)
//                                    {
//                                        chageAlpha = 0.5f;

//                                        if (AlphaTimer > 90 / 2)
//                                        {
//                                            chageAlpha = 0.45f;
//                                            if (AlphaTimer > 100 / 2)
//                                            {
//                                                chageAlpha = 0.4f;
//                                                if (AlphaTimer > 110 / 2)
//                                                {
//                                                    chageAlpha = 0.35f;
//                                                    if (AlphaTimer > 120 / 2)
//                                                    {
//                                                        chageAlpha = 0.3f;
//                                                        if (AlphaTimer > 130 / 2)
//                                                        {
//                                                            chageAlpha = 0.25f;
//                                                            if (AlphaTimer > 140 / 2)
//                                                            {
//                                                                chageAlpha = 0.2f;
//                                                                if (AlphaTimer > 150 / 2)
//                                                                {
//                                                                    chageAlpha = 0.15f;
//                                                                    AlphaTimer = 0;
//                                                                }
//                                                            }
//                                                        }
//                                                    }
//                                                }
//                                            }
//                                        }
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//        }

//        this.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, changeBlue, chageAlpha);
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAlpha : MonoBehaviour
{
    float changeRed = 1.0f;
    float changeGreen = 1.0f;
    float changeBlue = 1.0f;
    float chageAlpha = 0.1f;

    int AlphaTimer;
    void Start()
    {
        AlphaTimer = 0;
    }

    void Update()
    {
        AlphaTimer++;

        switch (AlphaTimer)
        {
            case 10:
                chageAlpha = 0.15f;
                break;
            case 15:
                chageAlpha = 0.25f;
                break;
            case 20:
                chageAlpha = 0.3f;
                break;
            case 25:
                chageAlpha = 0.35f;
                break;
            case 30:
                chageAlpha = 0.4f;
                break;
            case 35:
                chageAlpha = 0.45f;
                break;
            case 40:
                chageAlpha = 0.5f;
                break;
            case 45:
                chageAlpha = 0.45f;
                break;
            case 50:
                chageAlpha = 0.4f;
                break;
            case 55:
                chageAlpha = 0.35f;
                break;
            case 60:
                chageAlpha = 0.3f;
                break;
            case 65:
                chageAlpha = 0.25f;
                break;
            case 70:
                chageAlpha = 0.2f;
                break;
            case 75:
                chageAlpha = 0.15f;
                AlphaTimer = 0;
                break;
        }
        //if (AlphaTimer > 10)
        //{
        //    if (AlphaTimer > 20 / 2)
        //    {
        //        chageAlpha = 0.2f;
        //        if (AlphaTimer > 30 / 2)
        //        {
        //            if (AlphaTimer > 40 / 2)
        //            {
        //                if (AlphaTimer > 50 / 2)
        //                {
        //                    if (AlphaTimer > 60 / 2)
        //                    {
        //                        if (AlphaTimer > 70 / 2)
        //                        {
        //                            if (AlphaTimer > 80 / 2)
        //                            {

        //                                if (AlphaTimer > 90 / 2)
        //                                {
        //                                    if (AlphaTimer > 100 / 2)
        //                                    {
        //                                        if (AlphaTimer > 110 / 2)
        //                                        {
        //                                            if (AlphaTimer > 120 / 2)
        //                                            {
        //                                                if (AlphaTimer > 130 / 2)
        //                                                {
        //                                                    if (AlphaTimer > 140 / 2)
        //                                                    {
        //                                                        if (AlphaTimer > 150 / 2)
        //                                                        {
                                                
        //                                                        }
        //                                                    }
        //                                                }
        //                                            }
        //                                        }
        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        this.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, changeBlue, chageAlpha);
    }
}