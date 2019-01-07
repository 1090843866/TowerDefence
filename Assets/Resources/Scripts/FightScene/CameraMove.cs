using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraMove : MonoBehaviour
{
    private bool isDrag = false;
    void OnMouseDrag()
    {
        //Debug.Log("enter");
        //if(!EventSystem.current.IsPointerOverGameObject())
        //{
        //    isDrag = true;
        //}
    }
    void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            isDrag = true;
        }
    }
    void OnMouseUp()
    {
        //if (!EventSystem.current.IsPointerOverGameObject())
        //{
        //    isDrag = false;
        //}
        isDrag = false;
    }
    void Update()
    {
        if(isDrag)
        {
            Camera.main.transform.position += Input.GetAxis("Mouse X") * Vector3.left;
            if(Camera.main.transform.position.x <= 165.0f)
            {
                Camera.main.transform.position = new Vector3(165.0f, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }
            if (Camera.main.transform.position.x >= 255.0f)
            {
                Camera.main.transform.position = new Vector3(255.0f, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }
        }
    }

}
