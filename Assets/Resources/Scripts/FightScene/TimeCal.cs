using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 时间计时器
/// </summary>
public class TimeCal : MonoBehaviour
{
    [Header("时间显示控件")]
    public Text par, all;
    [Header("每波兵出兵速度增长率")]
    public float timeSpeed = 1.2f;

    public event Action FightFirst;
    [HideInInspector]
    public static TimeCal Instance = null;
    private float parTimeCount, parTimeSpan, allTimeCount;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Start ()
    {
        allTimeCount = 0.0f;
        parTimeSpan = 10.0f;
        parTimeCount = parTimeSpan;
    }
	
	void Update ()
    {
        //每波兵时间
        parTimeCount -= Time.deltaTime;
        par.text = ((int)parTimeCount/60).ToString() + ":" + ((int)parTimeCount % 60).ToString();
        if(parTimeCount <= 0.0f)
        {
            parTimeSpan *= timeSpeed;
            parTimeCount = parTimeSpan;
            //TODO：出兵,掉用函数
            if (FightFirst != null)
            {
                FightFirst(); 
            }
        }
        //总时间增加
        allTimeCount += Time.deltaTime;
        all.text = ((int)allTimeCount / 60).ToString() + ":" + ((int)allTimeCount % 60).ToString();
	}

}
