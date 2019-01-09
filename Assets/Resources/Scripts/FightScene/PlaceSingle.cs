using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSingle : MonoBehaviour
{
    public static PlaceSingle instance;

    private Transform place, obj;
    void Awake()
    {
        instance = this;
    }
    public void SetHero(Transform p, Transform o)
    {
        if(p != null)
        {
            place = p;
        }
        if(o != null)
        {
            obj = o;
        }
        if(place != null && obj != null)
        {
            GameObject go = GameObject.Instantiate(obj.gameObject, place, false);
        }
    }
}
