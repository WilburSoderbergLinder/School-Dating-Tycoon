using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TeacherPathfindingScript : MonoBehaviour
{
    //Säger åt läraren att gå till en position - Max
    public void SetDestination(Transform target)
    {
        GetComponent<AIDestinationSetter>().target = target;
    }

    public void SetDestination(Vector2 destination)
    {
        Transform newG = new GameObject().transform;
        newG.position = destination;
        SetDestination(newG);
    }
}
