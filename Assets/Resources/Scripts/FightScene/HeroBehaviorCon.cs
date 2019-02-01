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
    [HideInInspector]
    public bool isOnListener = false;

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
        if (isOnListener == false)
        {
            TimeCal.Instance.FightFirst += FightFirst;
        }
        else
        {
            if (target == null)
            {
                target = GameObject.FindGameObjectWithTag("target").transform;
            }
            SetHeroTarget(target);
        }
    }
    /// <summary>
    /// 第一次从出生点出兵
    /// </summary>
    public void FightFirst()
    {
        //复制自身出去战斗,禁止监听，寻找目标，切换动画
        GameObject go = GameObject.Instantiate(gameObject,gameObject.transform.TransformPoint(transform.localPosition), Quaternion.identity);
        //go.transform.localPosition = gameObject.transform.TransformPoint(transform.localPosition);
        go.transform.localScale = gameObject.transform.lossyScale;
        HeroBehaviorCon goBehaviorCon = go.GetComponent<HeroBehaviorCon>();
        goBehaviorCon.isOnListener = true;
    }
    /// <summary>
    /// 设置英雄的目标
    /// </summary>
    /// <param name="target"></param>
    public void SetHeroTarget(Transform target)
    {
        //TODO：需要修改，动态确定目标对象
        _agent.SetDestination(target.position);
    }
	void Update ()
    {
        if (!isOnListener)
        {
            return;
        }
        if (target != null && _agent.remainingDistance <= _agent.stoppingDistance)      //到达目的地

        { 
            _anim.SetBool("Run", false);
            _anim.SetBool("Attack", true);
            return;
        }
        if (target != null && _agent.remainingDistance > _agent.stoppingDistance)
        {
            _anim.SetBool("Run", true);
            _anim.SetBool("Attack", false);
            return;
        }
	}
    void OnDestroy()
    {
        DestroyListener();
    }
    public void DestroyListener()
    {
        TimeCal.Instance.FightFirst -= FightFirst;
    }

    void AttackEvent()
    {
        //对目标进行攻击
        if (target == null)
        {
            return;
        }
        transform.LookAt(target);
    }
}
