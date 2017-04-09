using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour {
    public GameObject Monster;
    public float delayTime=5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Spawn.spawncomplete)
        {
            delayTime -= Time.deltaTime;
            if (delayTime < 0)
            {
                Instantiate(Monster, new Vector3(9, 0.8f, 1), Quaternion.identity);
                delayTime = 0.5f;
            }
        }
	}
}
