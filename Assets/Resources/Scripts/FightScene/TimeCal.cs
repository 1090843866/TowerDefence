using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 时间计时器
/// </summary>
public class TimeCal : MonoBehaviour
{
    public Text par, all;
    [Header("每波兵出兵速度增长率")]
    public float timeSpeed = 1.2f;
    private float parTimeCount, parTimeSpan, allTimeCount;
	// Use this for initialization
	void Start ()
    {
        allTimeCount = 0.0f;
        parTimeSpan = 30.0f;
        parTimeCount = parTimeSpan;
    }
	
	void Update ()
    {
        //每波兵时间
        parTimeCount -= Time.deltaTime;
        par.text = ((int)parTimeCount/60).ToString() + ":" + ((int)parTimeCount % 60).ToString();
        if(parTimeCount >= parTimeSpan)
        {
            parTimeSpan *= timeSpeed;
            parTimeCount = parTimeSpan;
            //TODO：出兵,掉用函数

        }
        //总时间增加
        allTimeCount += Time.deltaTime;
        all.text = ((int)allTimeCount / 60).ToString() + ":" + ((int)allTimeCount % 60).ToString();
	}
}
