using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/// <summary>
/// 每个英雄的AI寻路控制
/// </summary>
public class AgentTest : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent _agent;
    private Animator _anim;
	void Start ()
    {
        _anim = this.GetComponent<Animator>();
        //_anim.SetBool("Run", true);
        _agent = this.GetComponent<NavMeshAgent>();
        _agent.stoppingDistance = 2.0f;
        //_agent.SetDestination(target.position);
	}
    /// <summary>
    /// 设置英雄的目标
    /// </summary>
    /// <param name="target"></param>
    public void SetHeroTarget(Transform target)
    {

    }

	void Update ()
    {
		
	}
}
