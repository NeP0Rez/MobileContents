using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MonsterLife : MonoBehaviour {


    public float HP = 100;
    public Slider MonsterHPbar;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        MonsterHPbar.value= HP;
        

        if (HP <= 0)
            Destroy(gameObject);


	}
}
