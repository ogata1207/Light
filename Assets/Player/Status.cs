using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour {

    public int Health = 1000;
    public int AtkPower = 200;
    public int DefPower = 100;
    public float Speed = 0.1f;
    private int SkillPoint;


    //体力のゲッターとセッター
    public void SetHealth( int hp )
    {
        Health = hp;
    }

    public int GetHealth()
    {
        return Health;
    }

    //スピードのゲッターとセッター
    public void SetSpeed( float sp )
    {
        Speed = sp;
    }
    public float GetSpeed()
    {
        return Speed;
    }

    //スキルポイントのゲッターとセッター
    public void SetSkillPoint( int sp )
    {
        SkillPoint = sp;
    }

    public int GetSkillPoint()
    {
        return SkillPoint;
    }

    //攻撃力
    public void SetAtkPower( int atk )
    {
        AtkPower = atk;
    }

    public int GetAtkPower()
    {
        return AtkPower;
    }

    //防御力
    public void SetDefPower( int def )
    {
        DefPower = def;
    }

    public int GetDefPower()
    {
        return DefPower;
    }

    //ダメージ計算
    public void DamageProc(int Atk, int Def)
    {
        int Dmg = Atk - Def;
        if (Dmg < 0) return;
        Health -= Dmg;
    }

	// Use this for initialization
	void Start ()
    {
        
        
        SkillPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (SkillPoint >= 4) SkillPoint = 4;
	}
}
