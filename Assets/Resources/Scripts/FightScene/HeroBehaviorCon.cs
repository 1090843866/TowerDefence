using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/// <summary>
/// 每个英雄的AI寻路控制
/// </summary>
public class HeroBehaviorCon: MonoBehaviour
{
    [HideInInspector]
    public int heroIndex;
    public Transform target;

    private NavMeshAgent _agent;
    private Animator _anim;
    private HeroBasicInfo? _info;
	void Start ()
    {
        _anim = this.GetComponent<Animator>();
        //_anim.SetBool("Run", true);
        _agent = this.GetComponent<NavMeshAgent>();
        //_agent.stoppingDistance = 2.0f;
        //_agent.SetDestination(target.position);
        //初始化英雄信息
        _info = HeroInfoCon.Instance.GetHeroBasicInfo(heroIndex);
        if (_info != null)
        {
            _agent.stoppingDistance = _info.Value.attackRange;
        }
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
        if (target != null)
        {
            return;
        }

	}
}
