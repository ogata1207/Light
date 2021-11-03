//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerLight : MonoBehaviour {
//    GameObject PlayerPointLight;
//    int Timer;
//	// Use this for initialization
//	void Start () {
//        PlayerPointLight = GameObject.Find("PlayerLight");
//        Timer = 0;
//    }
	
//	// Update is called once per frame
//	void Update () {
//		if(PlayerPointLight.GetComponent<Skill>().PlayerSkillLightUse)
//        {
//            Timer++;
//            if (Timer > 60)
//            {
//                PlayerPointLight.GetComponent<PlayerLightScript>().light.range -= 0.5f;
//                if (Timer > 60 * 2)
//                {
//                    PlayerPointLight.GetComponent<PlayerLightScript>().light.range -= 0.5f;
//                    if (Timer > 60 * 3)
//                    {
//                        PlayerPointLight.GetComponent<PlayerLightScript>().light.range -= 0.5f;
//                    }
//                }
//            }
//        }

//	}
//}
