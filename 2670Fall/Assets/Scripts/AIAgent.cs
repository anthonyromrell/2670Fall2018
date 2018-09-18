using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
//Made By Anthony Romrell
public class AIAgent : MonoBehaviour
{
	private NavMeshAgent agent;
	public Transform Destination;
	public Transform PostPoint;
	private Transform finalDestination;
	
	private void Start ()
    {
	    agent = GetComponent<NavMeshAgent>();
	    finalDestination = transform;
    }

	private void OnTriggerEnter(Collider obj)
	{
		if(obj.transform == Destination)
			finalDestination = Destination;
	}

	private void OnTriggerExit(Collider obj)
	{
		finalDestination = PostPoint; 
	}

	private void Update()
	{
		agent.destination = finalDestination.position;
	}
}