using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWaveToggle : MonoBehaviour {
    
    private Emitter emitter;
    public GameObject WaveText;
    public int Timer;
    public int NowWaves;
    float startTime = Time.time;
    // Use this for initialization
    void Start () {
        Timer = 60 * 3;
        NowWaves = emitter.now;
        emitter = GameObject.Find("Emitter").GetComponent<Emitter>();
    }

	
	// Update is called once per frame
	void FixedUpdate () {
        emitter = GameObject.Find("Emitter").GetComponent<Emitter>();
        Timer--;
        if (0 >= Timer)
        {
            Timer = 0;
            WaveText.SetActive(false);
        }
        NowWaves = emitter.now;
        if ( NowWaves != emitter.now )
        {
            NowWaves = emitter.now;
            Timer = 60 * 3;
            WaveText.SetActive(true);
        }

        

        
	}
}
