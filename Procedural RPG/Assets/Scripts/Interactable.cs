﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Interactable : MonoBehaviour {
    [HideInInspector]
    public NavMeshAgent playerAgent;
    private bool hasInteracted;
	public virtual void MoveToInteraction(NavMeshAgent playerAgent)
    {
        hasInteracted = false;
        this.playerAgent = playerAgent;
        playerAgent.destination = transform.position;
        playerAgent.stoppingDistance = 3.5f;
      

    }
    void Update()
    {
        if(playerAgent != null && !playerAgent.pathPending)
        {
            if (playerAgent.remainingDistance <= playerAgent.stoppingDistance && hasInteracted == false)
            {
                Interact();
                hasInteracted = true;
                
            }
        }
    }
    public virtual void Interact()
    {
        Debug.Log("This is interactable");
    }
}
