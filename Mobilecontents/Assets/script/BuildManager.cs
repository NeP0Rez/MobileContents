using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    void Awake()
    {
        if (instance != null) return;
            instance = this;
        
    }

    private GameObject turretToBuild;
    public GameObject[] standardTurretPrefab;

    void Start()
    {
        
    }

    public GameObject GetTurretToBuild(int rank,int randomIndex)
    {
        turretToBuild = standardTurretPrefab[(rank*5)+randomIndex];

        return turretToBuild;
    }

    
	
}
