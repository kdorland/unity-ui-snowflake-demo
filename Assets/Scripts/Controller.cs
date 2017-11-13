using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour {

    public GameObject controls;

    public void Start()
    {
        if (controls != null)
        {
            controls.SetActive(false);
        }
    }

    public void Log(string s)
    {
        Debug.Log(s);
    }

}
