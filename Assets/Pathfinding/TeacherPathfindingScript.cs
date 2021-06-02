using Pathfinding;
using UnityEngine;

public class TeacherPathfindingScript : MonoBehaviour
{
    //Säger åt läraren att gå till en position, använder Transform - Max
    public void SetDestination(Transform target)
    {
        GetComponent<AIDestinationSetter>().target = target;
    }

    //Säger åt läraren att gå till en position, använder Vector2 - Max
    public void SetDestination(Vector2 destination)
    {
        Transform newG = new GameObject().transform;
        newG.position = destination;
        SetDestination(newG);
    }
}
