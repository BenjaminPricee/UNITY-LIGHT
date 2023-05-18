using UnityEngine;
using UnityEngine.AI;

public class Rat : MonoBehaviour
{
    private NavMeshAgent nav;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.destination = NewDestination();
    }

    private void Update()
    {
        if(nav.remainingDistance >1)
        {
            nav.destination = NewDestination();
        }

    }

    private Vector3 NewDestination()
    {
        Vector3 newDest = new Vector3();

        Vector3 randomDir = Random.onUnitSphere;
        randomDir.y = 0;

        RaycastHit hit;
        if(Physics.Raycast(transform.position,randomDir,out hit))
        {
            newDest = hit.point;
            newDest.y = .01f;
        }
        else
        {
            newDest = NewDestination();
        }

        return newDest;
    }
}
