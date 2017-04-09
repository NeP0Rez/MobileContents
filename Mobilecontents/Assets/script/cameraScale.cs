using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScale : MonoBehaviour {
    Camera cm;
	// Use this for initialization
	void Start () {
        cm = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        cm.fieldOfView = (float)ScrollBar.CameraScale;
	}
}
