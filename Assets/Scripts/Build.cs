using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Build : MonoBehaviour
{
    public GameObject BuildMenu;
    public GameObject ClassroomMenu; 
    GameObject ConstructionArea;
    GameObject BuildArea;
    public GameObject TestObject;
    void Start()
    {
        BuildMenu.SetActive(false);
        ClassroomMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);

            if (hit && hit.transform.tag == "ConstructionArea")
            {
                Debug.Log(hit.transform.name);
                BuildMenu.SetActive(true);
                ConstructionArea = hit.transform.gameObject;
            } 
            
            else if (hit && hit.transform.tag == "BuildArea")
            {
                Debug.Log(hit.transform.name);
                ClassroomMenu.SetActive(true);
                BuildArea = hit.transform.gameObject;
            }

        }
    }

    public void build (GameObject builditem)
    {
        Instantiate(builditem,ConstructionArea.transform.position,Quaternion.identity);
        Destroy(ConstructionArea);
        BuildMenu.SetActive(false);
    }

    public void build2 (GameObject builditem)
    {
        Instantiate(builditem, BuildArea.transform.GetChild(0).position, Quaternion.Euler(-90,0,0));
        Destroy(BuildArea);
        ClassroomMenu.SetActive(false);
    }
}
