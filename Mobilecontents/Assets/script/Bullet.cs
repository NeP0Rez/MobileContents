using UnityEngine;

public class Bullet : MonoBehaviour {

    private Transform target;
    public GameObject bulletImpact;


    [Header("Use FlameStrike")]
    public bool FlameStrike = false;

    private bool Hit = false;

    public float explosionRadius = 0f;
    public float speed = 70f;
    private float damege;

    public void SetDamege(float _damege)
    {
        damege = _damege;
    }


    public void Seek (Transform _target)
    {
        target = _target;
        Hit = false;
    }
    
	// Update is called once per frame
	void Update () {
		if(target == null)
        {
            Destroy(gameObject);
            return;
        }
        if (!Hit)
        {
            Vector3 dir = target.position - transform.position;
            float distanceThisFrame = speed * Time.deltaTime;

            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                Hit = true;
                return;
            }

            transform.Translate(dir.normalized * distanceThisFrame, Space.World);
            transform.LookAt(target);
        }
	}
    
    void HitTarget()
    {
        if (FlameStrike)
        {
            GameObject effectIns = (GameObject)Instantiate(bulletImpact, transform.position, Quaternion.identity);
            effectIns.transform.eulerAngles = new Vector3(-90, 0, 0); 
            Destroy(effectIns, 5f);
        }
        else {
            GameObject effectIns = (GameObject)Instantiate(bulletImpact, transform.position, transform.rotation);
            Destroy(effectIns, 5f);
        }
        if (explosionRadius > 0f)
        {
            Explode();
        }
        else {
            Damege(target);
        }
        
        Destroy(gameObject);
    }

    void Explode()
    {
        Collider[] colliders =  Physics.OverlapSphere(transform.position, explosionRadius);
        foreach(Collider collider in colliders)
        {
            if(collider.tag=="monster")
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

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }

}
