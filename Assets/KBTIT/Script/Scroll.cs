using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {
    float changeRed = 1.0f;
    float changeGreen = 1.0f;
    float changeBlue = 1.0f;
    float chageAlpha = 1.0f;

    SpriteRenderer sp;
    public float speed = 10;
    public int spriteCount = 2;
    void Star()
    {
    }
    void Update()
    {
        // 左へ移動
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    void OnBecameInvisible()
    {
        // スプライトの幅を取得
        float width = GetComponent<SpriteRenderer>().bounds.size.x;
        // 幅ｘ個数分だけ右へ移動
        transform.position += Vector3.right * width * spriteCount;
    }
}
