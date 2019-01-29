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
            go.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Textures/FightScene/" + "battle-end_04");
            go.GetComponent<CardInfoCon>().cardName = CardBasicInfo.Instance.GetCardName(i);
            go.GetComponent<CardInfoCon>().cardCost = CardBasicInfo.Instance.GetCardCost(i);
        }
    }
}
