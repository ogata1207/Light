using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour {

    // Waveプレハブを格納する
    public GameObject[] waves;
    public GameObject gm;
    public GameObject text;
    // 現在のWave
    private int currentWave;
    GameObject scenemain;
    bool f=false;
    public int now = 0;
    public int NowWaves() { return currentWave; }
    public int MaxWaves() { return waves.Length; }
    IEnumerator Start()
    {
        scenemain = GameObject.FindWithTag("Main");

        // Waveが存在しなければコルーチンを終了する
        if (waves.Length == 0)
        {
            yield break;
        }

        while (true)
        {

            // Waveを作成する
            GameObject wave = (GameObject)Instantiate(waves[currentWave], transform.position, Quaternion.identity);

            // WaveをEmitterの子要素にする
            wave.transform.parent = transform;

            // Waveの子要素のEnemyが全て削除されるまで待機する
            while (wave.transform.childCount != 0)
            {
                yield return new WaitForEndOfFrame();
            }

            // Waveの削除
            Destroy(wave);
            
            text.SetActive(true);
            gm.GetComponent<ShowWaveToggle>().Timer = 60 * 3;
            now++;
            // 格納されているWaveを全て実行したらcurrentWaveを0にする（最初から -> ループ）
            if (waves.Length <= ++currentWave)
            {
                currentWave = 0;
                f = true;
            }

        }

    }
    void Update()
    {
        if (f)
        {
            scenemain.GetComponent<SceneMain>().MoveResult = true;
        }
    }
}
