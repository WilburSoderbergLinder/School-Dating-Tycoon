using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherSpawner : MonoBehaviour
{

    public List<Vector3> spawnPositions = new List<Vector3>();

    [SerializeField] GameObject teacherPrefab = null;


    
    void Start()
    {
        int count = spawnPositions.Count;

        for (int i = 0; i < count; i++)
        {
            SpawnTeacher();
        }
    }

    public void SpawnTeacher()
    {

        int random = Random.Range(0, spawnPositions.Count - 1);
        Vector3 pos = spawnPositions[random];
        spawnPositions.RemoveAt(random);



        Instantiate(teacherPrefab, pos, Quaternion.identity);
    }
}
