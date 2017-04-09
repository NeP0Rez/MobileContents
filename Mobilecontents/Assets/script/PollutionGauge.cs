using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PollutionGauge : MonoBehaviour {
    public Slider PollutionBar;
    public static float pollutionGauge = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PollutionBar.value = pollutionGauge;
	}
}
