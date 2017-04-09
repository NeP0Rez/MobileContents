using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    private GameObject turret;
    private TowerDragAndDrop turretcheck;
    private int rank = 0;
    public static bool SpawnButton = false;
    public Vector3 offSet;

    void Update()
    {
        if (turret == null)
        {
            rank = 0; return;
        }
        if (turretcheck != null)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (turretcheck.check)
                {

                    if (!turretcheck.MouseOn)
                    {

                        GameObject UpgradeturretToBuild = BuildManager.instance.GetTurretToBuild(1, Random.Range(0, 5));
                        Destroy(turret);
                        turret = (GameObject)Instantiate(UpgradeturretToBuild, transform.position + offSet, transform.rotation);
                    }
                    else {
                        Destroy(turret);
                    }
                }
            }
        }

    }

    

    void OnMouseDown()
    {
        
            if (!SpawnButton) return;
            if (turret != null) return;
            if (Gold.StartGold < 100) return;
            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild(rank, Random.Range(0, 5));
            turret = (GameObject)Instantiate(turretToBuild, transform.position + offSet, transform.rotation);
            Gold.StartGold -= 100;
            turretcheck = turret.GetComponent<TowerDragAndDrop>();
        }




    }

