using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navToPlayer : MonoBehaviour
{
    public CharacterController cc;
    public NavMeshAgent agent;
    private Vector3 destination;

    public bool walk;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }

    void Update()
    {
        if (Vector3.Distance(destination, cc.transform.position) < 11.0f)
        {
            walk = true;
        }
        if (walk)
        {
            destination = cc.transform.position;
            agent.destination = destination;
        }
    }
}
