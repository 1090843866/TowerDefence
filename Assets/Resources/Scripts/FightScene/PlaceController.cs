using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceController : MonoBehaviour
{
	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}
    /// <summary>
    /// 底部按钮放置英雄
    /// </summary>
    void OnMouseUpAsButton()
    {
        //点击放置的物体
        bool result = PlaceSingle.instance.SetHero(this.transform, null);
        if(result)
        {
            //播放声音吧
        }
    }
}
