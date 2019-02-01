using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneInitCon : MonoBehaviour
{
    public GameObject cardPref;
    public Transform heroParent;
    void Start()
    {
        //场景初始化控制卡牌生成
        List<int> data = new List<int>(5);
        data.Add(1);
        data.Add(2);
        data.Add(3);
        data.Add(4);
        data.Add(0);
        InitCardInfo(data);
    }
    /// <summary>
    /// 初始化卡片生成
    /// </summary>
    /// <param name="infoList">卡片id的集合</param>
    public void InitCardInfo(List<int> infoList)
    {
        foreach (int i in infoList)
        {
            GameObject go = GameObject.Instantiate(cardPref, heroParent, false);
            //go.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Textures/FightScene/" + CardBasicInfo.Instance.GetCardInfo(i));
            go.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Textures/FightScene/" + "battle-end_04");
            go.GetComponent<CardInfoCon>().cardIndex = i;
        }
    }
}
