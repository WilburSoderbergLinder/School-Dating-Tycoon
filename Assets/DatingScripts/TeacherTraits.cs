using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherTraits : MonoBehaviour
{
    public int[] traits = new int[6];
    void Start()
    {

        for (int i = 0; i < traits.Length -1; i++)
        {
            traits[i] = Random.Range(0, 5);
        }
        traits[traits.Length -1] = Random.Range(0, 1);
    }

    private void OnMouseDown()
    {
        FindObjectOfType<TeacherPairing>().Pair(this);
    }
}
