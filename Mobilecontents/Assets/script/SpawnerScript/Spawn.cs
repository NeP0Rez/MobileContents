using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public static int[,] map = new int[12,12];
    public static bool spawncomplete= false;
    public GameObject Cube;
    public GameObject MonsterRoad;
    public GameObject SideLine;
    public int x = 0, y = 0;
	// Use this for initialization
	void Start () {
        
       map = new int[,]{
{2,2,2,2,2,2,2,2,2,2,2,2},
{2,0,0,0,1,1,1,1,0,1,1,2},
{2,0,0,0,1,0,0,1,0,0,1,2},
{2,0,0,0,1,0,0,1,0,0,1,2},
{2,1,1,1,1,1,1,1,1,1,1,2},
{2,1,0,0,1,0,0,1,0,0,0,2},
{2,1,0,0,1,0,0,1,0,0,0,2},
{2,1,1,1,1,1,1,1,1,1,1,2},
{2,0,0,0,1,0,0,1,0,0,1,2},
{2,1,0,0,1,0,0,1,0,0,1,2},
{2,1,1,1,1,0,0,1,1,1,1,2},
{2,2,2,2,2,2,2,2,2,2,2,2}
};


    }

    // Update is called once per frame
    void Update() {
        if (y < 12)
        {
            if (map[y, x]==0)
            {
                Instantiate(Cube, new Vector3(x, -0.5f, y), Quaternion.identity);
                
            } else if(map[y,x]==1)
            {
                Instantiate(MonsterRoad, new Vector3(x, -1f, y), Quaternion.identity);
            } else if(map[y,x]==2)
            {
                Instantiate(SideLine, new Vector3(x, 0, y-0.5f), Quaternion.identity);
            }
            
            x++;
            if (x > 11)
            {
                y++;
                x = 0;
            }
        } else
        {
            spawncomplete = true;
        }
	}
}
