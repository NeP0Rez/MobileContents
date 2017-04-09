using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraView : MonoBehaviour {
    public bool ViewChange = false;
    public bool Upgrade = false;
    public bool SpawnRandomTower = false;
    public Scrollbar sb;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnTower()
    {
        if (Upgrade) return;
        Node.SpawnButton = !Node.SpawnButton;
    }

    public void UpgradeTower()
    {
        if (SpawnRandomTower) return;
        TowerDragAndDrop.UpgradeTowerButton = !TowerDragAndDrop.UpgradeTowerButton;
    }

    public void SpawnTowerView()
    {
        if (Upgrade) return;
        ViewChange = !ViewChange;
        SpawnRandomTower = !SpawnRandomTower;
        sb.value = 0;
        if (!ViewChange)
        {
            transform.position = new Vector3(10f, 11.5f, 13f);
            transform.rotation = Quaternion.Euler(new Vector3(60, -130, 0));
        }
        else {
            transform.position = new Vector3(5.5f, 11f, 7f);
            transform.rotation = Quaternion.Euler(new Vector3(90, -90, 0));
        }
        
    }

    public void UpgradeView()
    {
        if (SpawnRandomTower) return;
        ViewChange = !ViewChange;
        Upgrade = !Upgrade;
        sb.value = 0;
        if (!ViewChange)
        {
            transform.position = new Vector3(10f, 11.5f, 13f);
            transform.rotation = Quaternion.Euler(new Vector3(60, -130, 0));
        }
        else {
            transform.position = new Vector3(5.5f, 11f, 7f);
            transform.rotation = Quaternion.Euler(new Vector3(90, -90, 0));
        }
        
    }
}
