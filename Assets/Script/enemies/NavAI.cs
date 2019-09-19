using UnityEngine;
using UnityEngine.AI;

public class NavAI : MonoBehaviour
{

    public GameObject theDestination;
    NavMeshAgent theAgent;

    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        theAgent.SetDestination(theDestination.transform.position);
    }
}