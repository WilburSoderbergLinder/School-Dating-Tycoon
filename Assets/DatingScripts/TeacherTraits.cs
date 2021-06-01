using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherTraits : MonoBehaviour
{
    public int[] traits = new int[6];

    [SerializeField] string[] firstNames = new string[0];
    [SerializeField] string[] lastNames = new string[0];

    public string fullName = "";

    void Start()
    {
        traits[0] = Random.Range(0, 5);
        traits[1] = Random.Range(0, 5);
        traits[2] = Random.Range(0, 5);
        traits[3] = Random.Range(0, 5);
        traits[4] = Random.Range(0, 5);
        traits[5] = Random.Range(0, 5);

        fullName = firstNames[Random.Range(0, firstNames.Length)] + lastNames[Random.Range(0, lastNames.Length)];
    }

    private void OnMouseDown()
    {
        FindObjectOfType<TeacherPairing>().Pair(this);
    }
}
