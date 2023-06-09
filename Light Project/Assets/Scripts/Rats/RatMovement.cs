using UnityEngine;
using UnityEngine.AI;

public class RatMovement : MonoBehaviour
{
    private NavMeshAgent nav;
    private const int SEEK_RADIUS = 15;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.destination = NewDestination();
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, nav.destination) < 1)
        {
            nav.destination = NewDestination();
        }

    }

    private Vector3 NewDestination()
    {
        Vector3 randomDirection = Random.insideUnitSphere * SEEK_RADIUS;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, SEEK_RADIUS, 1);
        Vector3 finalPosition = hit.position;

        return finalPosition;
    }
}
