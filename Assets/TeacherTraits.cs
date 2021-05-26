using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherTraits : MonoBehaviour
{
    public int[] traits = new int[6];
    void Start()
    {
        traits[0] = Random.Range(0, 4);
        traits[1] = Random.Range(0, 4);
        traits[2] = Random.Range(0, 4);
        traits[3] = Random.Range(0, 4);
        traits[4] = Random.Range(0, 4);
        traits[5] = Random.Range(0, 4);
    }

    private void OnMouseDown()
    {
        FindObjectOfType<TeacherPairing>().Pair(this);
    }
}
