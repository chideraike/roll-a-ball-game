using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    
    private NavMeshAgent navMeshAgent;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        if (target != null)
        {
            navMeshAgent.SetDestination(target.position);
        }
    }
}
