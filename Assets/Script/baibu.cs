using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure; // Required in C#

public class baibu : MonoBehaviour
{

    PlayerIndex playerIndex;
    private float Timer = 1f;
    private float Power = 0f;

    private bool VibrationFlg = false;

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        //パワーを0にしないと一生揺れる
        GamePad.SetVibration(playerIndex, Power, Power);
    }

    // Update is called once per frame
    void Update()
    {
        if ( VibrationFlg ) StartCoroutine( Vibration( Timer, Power ) );
    }

    IEnumerator Vibration(float time, float power = 0.1f)
    {
        //現在の時間を保存
        var startTime = Time.time;
        
        //振動の力をセット
        Power = power;

        // 現在の時間 - 保存した時間 = コルーチンがスタートしてからの時間(秒)
        while (Time.time - startTime < time)
        {
            //ここは振動している間の処理

            yield return null;
        }

        //これやらんと一生震えてる
        Power = 0f;
        VibrationFlg = false;
    }
    public void SetVibration(float time = 1f, float power = .1f)
    {
        Timer = time;
        Power = power;
        VibrationFlg = true;
    }



}
