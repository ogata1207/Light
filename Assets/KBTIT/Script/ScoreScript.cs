using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    static public int score = 0;

    public void AddPoint(int p)
    {
        score = score + p;
    }

    void Start()
    {
        scoreText.text = "Score:0";
    }
    void Update()
    {
        scoreText.text = "Score:" + score.ToString();
    }
}
