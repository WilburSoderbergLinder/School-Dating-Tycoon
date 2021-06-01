using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherSpawner : MonoBehaviour
{

    [SerializeField] List<Vector3> spawnPositions = new List<Vector3>();

    [SerializeField] GameObject teacherPrefab = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTeacher()
    {

        int random = Random.Range(0, spawnPositions.Count - 1);
        Vector3 pos = spawnPositions[random];
        spawnPositions.RemoveAt(random);



        Instantiate(teacherPrefab, pos, Quaternion.identity);
    }
}
