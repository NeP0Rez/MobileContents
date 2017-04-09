using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScrollBar : MonoBehaviour {
    Scrollbar sb;
    public static int CameraScale=0;
	// Use this for initialization
	void Start () {
        sb = GetComponent<Scrollbar>();
	}
	
	// Update is called once per frame
	void Update () {
        CameraScale = 60 - ((int)(sb.value * 40));
	}

   
}
