using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gold : MonoBehaviour {

    public Text GoldText;
    public static int StartGold= 10000;
    private float goldDelay=1.0f;

	// Use this for initialization
	void Start () {
        GoldText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        GoldText.text = StartGold.ToString();
        if(goldDelay <=0)
        {
            StartGold += 10;
            goldDelay = 1;
        }
        goldDelay -= Time.deltaTime;

    }
}
