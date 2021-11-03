using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowWaves : MonoBehaviour {
    public Text t;
    Emitter emitter;
    public int waves;
    // Use this for initialization
    void Start () {
        waves = emitter.now;
        emitter = GameObject.Find("Emitter").GetComponent<Emitter>();

	}
	
	// Update is called once per frame
	void Update () {
        emitter = GameObject.Find("Emitter").GetComponent<Emitter>();
        waves = emitter.now;
        if (emitter.MaxWaves() == waves) t.text = " Final Wave";
        else t.text = "Wave " + ( 1 + emitter.now );
	}
}
