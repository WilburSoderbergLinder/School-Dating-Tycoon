using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeacherTraits : MonoBehaviour
{
    public int[] traits = new int[6];

    [SerializeField] string[] firstNames = new string[0];
    [SerializeField] string[] lastNames = new string[0];
    
    public string fullName = "";
    Text nameText;
    void Start()
    {
        nameText = GetComponentInChildren<Text>();

        for (int i = 0; i < traits.Length -1; i++)
        {
            traits[i] = Random.Range(0, 5);
        }
        traits[traits.Length -1] = Random.Range(0, 1);


        fullName = firstNames[Random.Range(0, firstNames.Length)] + " " + lastNames[Random.Range(0, lastNames.Length)];
        nameText.text = fullName;
        
    }

    private void OnMouseDown()
    {
        FindObjectOfType<TeacherPairing>().Pair(this);
    }
}
