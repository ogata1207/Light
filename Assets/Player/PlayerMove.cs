using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    // 移動スピード
    // public float speed = 5;

    
    public bool コントローラー = false;
    public bool 仮で作ったアニメーション = true;
    Status status;
    Skill skill;
    //移動量
    private Vector2 Move = new Vector2(2.0f, 2.0f);
    private float Speed = 0.1f;
    private Animator anim;
    //移動関数
    private delegate void moveproc();
    private moveproc MoveProc;

    void Start()
    {
        //コントローラーとキー操作の切り替え
        if (コントローラー) MoveProc = new moveproc(Controller);
        else MoveProc = new moveproc(KeyControl);

        //プレイヤーステータス
        status = GetComponent<Status>();
        status.SetSpeed(Speed);         //初期のスピードをセット

        //スキル
        skill = GetComponent<Skill>();

        //あにｍ
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //仮　スキルポイントアップ
        if( Input.GetButtonDown("AddSkillPoint"))
        {
            status.SetSkillPoint(status.GetSkillPoint() + 1);
        }
        
        MoveProc();

    }

    void Controller()
    {

        // スキル使用
        if (Input.GetButtonDown("UseSkill"))
        {
            skill = GetComponent<Skill>();
            skill.PlaySkill();
        }

        Vector2 Position = transform.position;
        Speed = status.GetSpeed();      //現在のスピードを取得

        // 右・左
        float x = Input.GetAxisRaw("Horizontal");
        // 上・下
        float y = Input.GetAxisRaw("Vertical");

        //アニメーション変更
        if (仮で作ったアニメーション == true)
        {
            if (y > 0)
            {
                anim.SetBool("bUp", true);
                anim.SetTrigger("Up");
            }
            else
            {
                anim.ResetTrigger("Up");
                anim.SetBool("bUp", false);
            }

            if (y < 0)
            {
                anim.SetBool("bDown", true);
                anim.SetTrigger("Down");
            }
            else
            {
                anim.ResetTrigger("Down");
                anim.SetBool("bDown", false);
            }

        }
        // 画面左下のワールド座標をビューポートから取得 get lower left (in world coordinate) from ViewPort
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, .2f));

        // 画面右上のワールド座標をビューポートから取得 get upper right (in world coordinate) from ViewPort
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        //移動
        Position.x += x * Speed;
        Position.y += y * Speed;


        // プレイヤーの位置が画面内に収まるように制限をかける not to over from the view
        Position.x = Mathf.Clamp(Position.x, min.x, max.x);
        Position.y = Mathf.Clamp(Position.y, min.y, max.y);

        transform.position = Position;

    }


    void KeyControl()
    {
        // スキル使用
        if (Input.GetKeyDown(KeyCode.P))
        {
            //skill = GetComponent<Skill>();
            skill.PlaySkill();
        }


        Vector2 Position = transform.position;

        Speed = status.GetSpeed();
        //左右移動
        if (Input.GetKey(KeyCode.A))
        {
            
            Position.x -=  Move.x * Speed;
           
        }
        else if (Input.GetKey(KeyCode.D))
        {
           
            Position.x +=  Move.x * Speed;
 
        }

        //上下移動

        if (Input.GetKey(KeyCode.W))
        {
            Position.y +=  Move.y * Speed;
        }else if( Input.GetKey(KeyCode.S))
        {
            Position.y -=  Move.y * Speed;
        }

        //移動
        transform.position = Position;
    }
}
