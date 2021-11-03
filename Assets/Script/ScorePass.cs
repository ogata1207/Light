using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePass : MonoBehaviour {
    public Text scoreGUI;
    // Use this for initialization
    void Start () {
        scoreGUI = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreGUI.text = Application.dataPath;

    }
}
