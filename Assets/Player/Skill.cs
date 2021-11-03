using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic; // ここコピペ


public class Skill : MonoBehaviour
{
    [SerializeField, MultilineAttribute(2)]
    string message1 = "スピードアップ最大数と増加量の数は合わせる";
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    public float[] AddSpeed;
    public int スピードアップ最大回数 = 5;
    public int 子機の最大数 = 4;
    private int KokiNum = 0;
    private Status status;
    private int SpeedUpNum;
    private int SkillState;
    public GameObject LightShot;
    public GameObject PlayerLight;
    public GameObject ItemUseEffect;

    private int PlayerLightTimer;
    public bool PlayerSkillLightUse;

    public int GetSpeedUpNum() { return SpeedUpNum; }
    public int GetKokiNum() { return KokiNum; }
    //public PlayerLightScript PlayerLight;
    //public bool LightShotFlg;
    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ

        SkillState = 0;
        PlayerSkillLightUse = false;
        status = GetComponent<Status>();
        PlayerLightTimer = 0;
        PlayerLight = GameObject.Find("PlayerLight");
    }

    // Update is called once per frame
    void Update()
    {
        SkillState = status.GetSkillPoint();
    }


    // スキル1つ目
    public void Skill_SpeedUp()
    {
        
        float Speed = status.GetSpeed();
        if (SpeedUpNum < スピードアップ最大回数)
        {
           
            Speed *= AddSpeed[SpeedUpNum];
            SpeedUpNum++;
        }
        else return;        //  2017/12/9 追加 (スピードアップの使用回数が最大に達していた時にスルーするーの)
        audioSource.PlayOneShot(audioClip[0]);  // ここコピペ
        SkillState = 0;
        GameObject Obj = Instantiate(ItemUseEffect, transform.position, Quaternion.identity) as GameObject;
        Destroy(Obj, 0.3f);
        //ステータス更新
        status.SetSkillPoint(SkillState);
        status.SetSpeed(Speed);

    }
    // スキル2つ目
    public void Skill_AddFollower()
    {
        
        if ( KokiNum < 子機の最大数 ) GetComponent<follower>().SetFollower();
        else return;//  2017/12/9 追加 (子機の数が最大に達していた時にスルーするーの)
        audioSource.PlayOneShot(audioClip[0]);  // ここコピペ
        KokiNum++;
        SkillState = 0;
        GameObject Obj = Instantiate(ItemUseEffect, transform.position, Quaternion.identity) as GameObject;
        Destroy(Obj, 0.3f);
        //ステータス更新
        status.SetSkillPoint(SkillState);

    }

    // スキル3つ目
    public void Skill_Light()
    {
        audioSource.PlayOneShot(audioClip[0]);  // ここコピペ

        // 初期値PlayerLightRange1.8f
        PlayerLight.GetComponent<PlayerLightScript>().light.range += 3.2f;

        if (PlayerLight.GetComponent<PlayerLightScript>().light.range >= 5.0f)
        {
            PlayerSkillLightUse = true;
            PlayerLight.GetComponent<PlayerLightScript>().light.range = 5.0f;
        }
        //else
        //{
        //    PlayerSkillLightUse = false;
        //}
        GameObject Obj = Instantiate(ItemUseEffect, transform.position, Quaternion.identity) as GameObject;
        Destroy(Obj, 0.3f);
        SkillState = 0;
        //ステータス更新
        status.SetSkillPoint(SkillState);
    }

    // スキル4つ目
    public void Skill_LightShot()
    {
        audioSource.PlayOneShot(audioClip[0]);  // ここコピペ

        Vector3 pos = transform.position;
        //pos.x += 0.1f;
        Instantiate(LightShot, pos, transform.rotation);
        SkillState = 0;
        GameObject Obj = Instantiate(ItemUseEffect, transform.position, Quaternion.identity) as GameObject;
        Destroy(Obj, 0.3f);
        //ステータス更新
        status.SetSkillPoint(SkillState);
    }

    public void PlaySkill()
    {

        switch (SkillState)
        {
            case 0:
                break;
            case 1:
                Skill_SpeedUp();
                break;
            case 2:
                Skill_AddFollower();
                break;
            case 3:
                Skill_Light();
                break;
            case 4:
                Skill_LightShot();
                break;
            case 5:
                Skill_LightShot();
                break;
            case 6:
                Skill_LightShot();
                break;
            default:
                status.SetSkillPoint(0);
                SkillState = 0;
                break;
        }


    }
}
