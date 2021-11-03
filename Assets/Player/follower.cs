using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{

    //オブジェクト
    public GameObject Prefab;
    private GameObject Player;
    public GameObject Bullet;
    private Status status;      //プレイヤーのステータス
    //リスト
    private List<GameObject> FollowerList = new List<GameObject>();
    //public List<GameObject> Flash = new List<GameObject>();
    //private GameObject UseFlash = null;

    //Followerの設定
    private float Vel = 5.0f;       //速度
    public float Dist = 1.0f;       //距離
    private int MaxFollowers = 4;   //子機の最大数
    public int NumFollowers = 0;    //現在の子機の数

    private float wait;
    public int Interval;

    //ゲッター・セッター


    public void SetFollower(Vector3 pos)
    {
        FollowerList.Add(Instantiate(Prefab, pos, Prefab.transform.rotation) as GameObject);
        NumFollowers++;
    }

    public void SetFollower()
    {
        FollowerList.Add(Instantiate(Prefab, Prefab.transform.position, Prefab.transform.rotation) as GameObject);
        NumFollowers++;
    }


    public Vector3 GetFollowerPos(int a)
    {
        //引数の値が現在のフォロワーの数より小さかったらその番号の子機のposをかえす
        //それ以外は一番後ろの子機のposをかえしてさしあげる

        if (NumFollowers > a) return FollowerList[a].transform.position;
        else return FollowerList[NumFollowers].transform.position;
    }
    //
    void Start()
    {
        wait = 0;
        //Interval = 5;

        //初期のフォロワーの数が0じゃないときに最初に生成させる
        if (NumFollowers != 0)
        {
            for (int i = 0; i < MaxFollowers; i++)
            {
                SetFollower();
            }
        }

        //Playerの情報を取得
        Player = GameObject.FindWithTag("Player");
        status = Player.GetComponent<Status>();

        //子機の速度をプレイヤーの速度に合わせる
        Vel = status.GetSpeed() * 100;

    }

    // Update is called once per frame

    void Update()
    {
        //今回は自機のスピードが変わる仕様なので
        //毎回スピードを再取得する
        Vel = status.GetSpeed() * 100;


        for (int i = 0; i < NumFollowers; i++)
        {

            Vector2 dir;
            if (i == 0)
                dir = -1 * FollowerList[i].transform.position + Player.transform.position;
            else
                dir = -1 * FollowerList[i].transform.position + FollowerList[i - 1].transform.position;

            if (dir.magnitude > Dist)

                FollowerList[i].GetComponent<Rigidbody2D>().velocity = dir.normalized * Vel;
            else
                FollowerList[i].GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

        }

        //弾発射(仮)    くそ適当にとりあえず作った
        if (Input.GetButton("NormalShot"))
        {
            wait++;

            if (wait > Interval)
            {
                for (int i = 0; i < NumFollowers; i++)
                {
                    //if (UseFlash == null)
                    //{
                    //    UseFlash = Instantiate(Flash[i], transform.position, transform.rotation);
                    //}
                    Vector3 pos = FollowerList[i].transform.position;
                    pos.x += .5f;
                    Instantiate(Bullet, pos, FollowerList[i].transform.rotation);
                }
                wait = 0;
            }

        }
        else if (Input.GetButtonUp("NormalShot"))
        {
            //Destroy(UseFlash);
            //UseFlash = null;
        }

    }


}
