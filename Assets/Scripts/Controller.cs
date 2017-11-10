using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour {


    public void Test()
    {
        Debug.Log("Hejsa");
    }

    public void Log(string s)
    {
        Debug.Log(s);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("I'm dragging");
    }

    public void OnClick(PointerEventData eventData)
    {
        Debug.Log("I'm clicking");
    }

}
