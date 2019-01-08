using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentTest : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent _agent;
    private Animator _anim;
	void Start ()
    {
        _anim = this.GetComponent<Animator>();
        _anim.SetBool("Run", true);
        _agent = this.GetComponent<NavMeshAgent>();
        _agent.stoppingDistance = 2.0f;
        _agent.SetDestination(target.position);
	}
	void Update ()
    {
		
	}
}
