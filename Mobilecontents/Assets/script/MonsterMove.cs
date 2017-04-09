using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public Vector3[] turnPoint;
    private Vector3 currPosition;
    private int turnPointIndex = 0;
    private float speed = 3f;
    private int destroyIndex = 13;
    void Start()
    {
        turnPoint = new Vector3[destroyIndex];

        turnPoint.SetValue(new Vector3(9, 0.8f, 1), 0);
        turnPoint.SetValue(new Vector3(10,0.8f,1), 1);
        turnPoint.SetValue(new Vector3(10, 0.8f,4), 2);
        turnPoint.SetValue(new Vector3(1, 0.8f,4), 3);
        turnPoint.SetValue(new Vector3(1, 0.8f,7), 4);
        turnPoint.SetValue(new Vector3(10, 0.8f,7), 5);
        turnPoint.SetValue(new Vector3(10, 0.8f,10), 6);
        turnPoint.SetValue(new Vector3(7, 0.8f,10), 7);
        turnPoint.SetValue(new Vector3(7, 0.8f,1), 8);
        turnPoint.SetValue(new Vector3(4, 0.8f,1), 9);
        turnPoint.SetValue(new Vector3(4, 0.8f,10), 10);
        turnPoint.SetValue(new Vector3(1, 0.8f,10), 11);
        turnPoint.SetValue(new Vector3(1, 0.8f,9), 12);

    }

    // Update is called once per frame
    void Update()
    {
        currPosition = transform.position;

        if(turnPointIndex < turnPoint.Length)
        {
            float step = speed * Time.deltaTime;

            transform.position = Vector3.MoveTowards(currPosition,turnPoint[turnPointIndex],step);

            if (Vector3.Distance(turnPoint[turnPointIndex], currPosition) < 0.01f)
                turnPointIndex++;
        }
        if (destroyIndex == turnPointIndex)
        {
            Destroy(this.gameObject);
            PollutionGauge.pollutionGauge += 0.01f;
        }
    }
}
