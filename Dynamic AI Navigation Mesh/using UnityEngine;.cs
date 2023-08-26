using UnityEngine;
using UnityEngine.AI;

public class DynamicNavigation : MonoBehaviour
{
    private NavMeshSurface navMeshSurface;

    private void Start()
    {
        navMeshSurface = GetComponent<NavMeshSurface>();
        UpdateNavMesh();
    }

    void UpdateNavMesh()
    {
        navMeshSurface.BuildNavMesh();
    }

    // Call this method when an obstacle changes
    public void ObstacleChanged()
    {
        UpdateNavMesh();
    }
}
