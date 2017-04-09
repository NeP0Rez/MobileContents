using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameStrikeParticle : MonoBehaviour {

    public float damege;
    public float explosionRadius;
    
    // Use this for initialization
    void Start () {
        
    	}
	
	// Update is called once per frame
	void Update () {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "monster")
            {
                Damege(collider.transform);
            }
        }
    }

    void Damege(Transform enemy)
    {
        GameObject Target = enemy.gameObject;
        MonsterLife Moblife = Target.GetComponent<MonsterLife>();
        Moblife.HP -= damege;
    }
}
