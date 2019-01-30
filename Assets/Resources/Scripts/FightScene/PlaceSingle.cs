using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSingle : MonoBehaviour
{
    public static PlaceSingle instance;

    private Transform place;
    private GameObject obj;
    private int heroIndex;
    void Awake()
    {
        instance = this;
    }
    /// <summary>
    /// 点击放置生成英雄
    /// </summary>
    /// <param name="p">底部要按钮</param>
    /// <param name="o">要生成的英雄</param>
    public bool SetHero(Transform p, GameObject o, int index)
    {
        //点击放置英雄
        if(p != null)
        {
            place = p;
        }
        if(o != null)
        {
            obj = o;
            heroIndex = index;
        }
        if(place != null && obj != null  && p != null && p.childCount <= 2)       //不存在英雄时生成
        {
            //验证金币是否充足等

            //生成英雄
            GameObject go = GameObject.Instantiate(obj.gameObject, place, false);
            go.transform.SetAsLastSibling();
            go.GetComponent<HeroBehaviorCon>().heroIndex = heroIndex;
            if (p.parent.name.Contains("Right"))
            {
                go.transform.Rotate(Vector3.up, 180, Space.World);
            }
            return true;
        }
        return false;
    }
}
