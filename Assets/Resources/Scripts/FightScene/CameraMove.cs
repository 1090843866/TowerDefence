using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraMove : MonoBehaviour
{
    //发布为安卓平台且在编辑器里
#if UNITY_EDITOR && UNITY_ANDROID
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
    //Android 平台
#elif UNITY_ANDROID && !UNITY_EDITOR
    void Update()
    {
        if(Input.touchCount <= 0)
        {
            return;
        }
        if(Input.touchCount == 1)
        {
            Debug.Log("etner");
            if(Input.touches[0].phase == TouchPhase.Moved)
            {
                Camera.main.transform.Translate(-Input.touches[0].deltaPosition.x, 0, 0, Space.World);
                if (Camera.main.transform.position.x <= 165.0f)
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
#endif
}
