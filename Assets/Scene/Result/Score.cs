using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Text; //Encoding
public class Score : MonoBehaviour
{

    public Text scoreGUI;
    public Text highscoreGUI;
    private int score;
    private int highScore = 0;

    private static string hs = "0";
    public TextAsset SaveData;
    void Start()
    {
        score = ScoreScript.score;
        if (int.Parse(hs) < score )
        {
            SaveHighScore(score);
           
        }
        ReadHighScore();
    }

    void Update()
    {

        // Scoreが現在のハイスコアを上回ったらhighScoreを更新
        Debug.Log(hs);
        scoreGUI.text = "" + score;
        highscoreGUI.text = hs;
    }

  
    public void SaveHighScore(int txt)
    {
        StreamWriter sw;
        FileInfo fi;
        fi = new FileInfo(Application.dataPath + "/SaveData.txt");

        sw = fi.CreateText();
        sw.Write(txt);
       
        sw.Flush();
        sw.Close();
    }

    void ReadHighScore()
    {
        // FileReadTest.txtファイルを読み込む
        FileInfo fi = new FileInfo(Application.dataPath + "/" + "SaveData.txt");
        
        {
            // 一行毎読み込み
            using (StreamReader sr = new StreamReader(fi.OpenRead(), Encoding.UTF8))
            {
                //highscoreGUI.text = sr.ReadToEnd();
                hs = sr.ReadLine();
            }
        }
        
    }
}