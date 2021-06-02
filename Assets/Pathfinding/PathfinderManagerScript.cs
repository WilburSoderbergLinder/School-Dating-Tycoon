using UnityEngine;
using Pathfinding;

public class PathfinderManagerScript : MonoBehaviour
{
    public static PathfinderManagerScript instance { get; private set; }

    //Skapar en ny pathfindingpunkt som lärarna har möjlighet att gå till - Max
    //Det borde göras vid dörrar, i klassrummen och sånt, överallt där lärarna ska kunna gå
    public void AddPathfindingPoint(Vector2 position)
    {
        Transform newG = new GameObject().transform;
        newG.position = position;
        newG.parent = transform;
        AstarPath.active.Scan();
    }
}
