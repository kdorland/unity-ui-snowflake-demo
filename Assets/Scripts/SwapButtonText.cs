using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapButtonText : MonoBehaviour {
    public string[] texts;
    public int activeText;
    public Button button;
    private Text text;

    void Start()
    {
        text = button.GetComponentInChildren<Text>(); 
        text.text = texts[activeText];
    }

    public void Click()
    {
        activeText = (activeText + 1) % texts.Length;
        text.text = texts[activeText];
    }
}
