using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour {
    public NavMeshAgent playerAgent;
	public virtual void MoveToInteraction(NavMeshAgent playerAgent)
    {
        this.playerAgent = playerAgent;
        playerAgent.destination = transform.position;
        playerAgent.stoppingDistance = 3.5f;
        Interact();

    }
    public virtual void Interact()
    {
        Debug.Log("This is interactable");
    }
}
