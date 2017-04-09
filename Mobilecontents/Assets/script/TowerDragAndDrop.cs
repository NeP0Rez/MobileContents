using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDragAndDrop : MonoBehaviour {

    public static bool UpgradeTowerButton = false;
    private Vector3 screenPoint;
    private Vector3 offset;
    public bool check = false;
    public bool MouseOnAndDrag = false;
    public bool MouseOn = false;
    Vector3 startVec;
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag==this.gameObject.tag && MouseOnAndDrag) 
        check = true;
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == this.gameObject.tag)
            check = false;
    }

	// Use this for initialization
	void Start () {
        startVec = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!UpgradeTowerButton) return;
        if (!MouseOnAndDrag)
        {
            check = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            MouseOnAndDrag = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            
            MouseOnAndDrag = false;
        }
    }
    void OnMouseDown()
    {
        if (!UpgradeTowerButton) return;
        MouseOn = true;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }

    void OnMouseDrag()
    {
        if (!UpgradeTowerButton) return;
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        
        transform.position = curPosition;

    }
    void OnMouseUp()
    {
        if (!UpgradeTowerButton) return;
        if (!check)
        {
            transform.position = startVec;
            MouseOn = false;
        }
        
    }
}
