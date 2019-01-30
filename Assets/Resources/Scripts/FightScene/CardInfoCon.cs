using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 存储卡片信息
/// </summary>
public class CardInfoCon : MonoBehaviour
{
    public int cardIndex;
    private string cardName;
    private int cardCost;
	// Use this for initialization
	void Start ()
    {
        this.GetComponent<Button>().onClick.AddListener(SetHero);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InitInfo()
    {

    }
    public void SetHero()
    {
        GameObject obj = Resources.Load<GameObject>("Model/PrefabHero/" + CardBasicInfo.Instance.GetCardName(cardIndex));
        PlaceSingle.instance.SetHero(null, obj, cardIndex);
    }
}
