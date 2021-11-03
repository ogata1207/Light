using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {

    private AsyncOperation async;		//　非同期動作で使用するAsyncOperation
    public Slider slider;			//　読み込み率を表示するスライダー
    [SerializeField, MultilineAttribute(2)]
    string message1 = "ロードするシーンは各シーン毎に設定しないといけない";

    static public string SceneName = "SceneMain";
    public void SetScene( string sName ) { SceneName = sName; }
    void Start()
    {
       
        //　コルーチンを開始
        StartCoroutine( LoadData() );
    }
    

    IEnumerator LoadData()
    {
       
        // シーンの読み込みをする
        async = SceneManager.LoadSceneAsync(SceneName);

        //　読み込みが終わるまで進捗状況をスライダーの値に反映させる
        while (!async.isDone)
        {
            float progressVal = Mathf.Clamp01(async.progress / 0.9f);
            slider.value = progressVal;
            yield return null;
            
        }
    }

}
