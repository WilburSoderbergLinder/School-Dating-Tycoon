using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    public GameObject BuildMenu;
    public GameObject ConstructionArea;
    public GameObject TestObject;
    void Start()
    {
        BuildMenu.SetActive(false);
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
            }

        }
    }

    public void build ()
    {
        Destroy(ConstructionArea);
        BuildMenu.SetActive(false);
        Instantiate(TestObject);
    }
}
