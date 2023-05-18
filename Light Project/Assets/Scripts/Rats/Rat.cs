using UnityEngine;
using UnityEngine.AI;

public class Rat : MonoBehaviour
{
    private NavMeshAgent nav;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.SetDestination(new Vector3(0, 0, 0));
    }
}
