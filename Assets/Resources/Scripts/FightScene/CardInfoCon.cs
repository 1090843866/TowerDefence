using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 存储卡片信息
/// </summary>
public class CardInfoCon : MonoBehaviour
{
    
	// Use this for initialization
	void Start ()
    {
        this.GetComponent<Button>().onClick.AddListener(SetHero);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetHero()
    {
        GameObject obj = Resources.Load<GameObject>("Model/Prefab/Mori");
        Debug.Log(obj.name);
        PlaceSingle.instance.SetHero(null, obj);
    }
}
