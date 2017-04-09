using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraMove : MonoBehaviour
{
    public float cameraMoveSpeed = 5f;
    public bool scrollBarTouch = false;
    void Start()
    {
        // owt? 
    }

    void Update()
    {
        if (TowerDragAndDrop.UpgradeTowerButton) return;
        if (!scrollBarTouch)
        cameraMove();

    }

    void cameraMove()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            transform.Translate(0, 0, -cameraMoveSpeed*Time.deltaTime);
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            transform.Translate(0, 0, cameraMoveSpeed * Time.deltaTime);
        }
        if (Input.GetMouseButton(0))
        {
            if (Input.GetAxis("Mouse X") < 0)
            {
                transform.Translate(cameraMoveSpeed * Time.deltaTime, 0, 0);
            }
        }
        if (Input.GetMouseButton(0))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.Translate(-cameraMoveSpeed * Time.deltaTime, 0, 0);
            }
        }
        if (Input.GetMouseButton(0))
        {
            if (Input.GetAxis("Mouse Y") < 0)
            {
                transform.Translate(0, cameraMoveSpeed * Time.deltaTime, 0);
            }
        }
        if (Input.GetMouseButton(0))
        {
            if (Input.GetAxis("Mouse Y") > 0)
            {
                transform.Translate(0, -cameraMoveSpeed * Time.deltaTime, 0);
            }
        }
        if (Input.GetMouseButton(1))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.Rotate(0, 0.5f, 0, Space.World);
                //transform.Translate(-0.17f, 0, 0);
            }
        }
        if (Input.GetMouseButton(1))
        {
            if (Input.GetAxis("Mouse X") < 0)
            {
                transform.Rotate(0, -0.5f, 0, Space.World);
                //transform.Translate(0.17f, 0, 0);
            }
        }
    }
    public void scrollBar()
    {
        scrollBarTouch = true;
    }
    public void scrollBarNoTouch()
    {
        scrollBarTouch = false;
    }
}