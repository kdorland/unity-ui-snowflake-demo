using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideUI : MonoBehaviour {

    public GameObject target;

    public void ShowHide()
    {
        target.SetActive(!target.activeSelf);
    }
}
