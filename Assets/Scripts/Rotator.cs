using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour {
    public bool active;
    public float speedX;
    public float speedY;
    public float speedZ;

    public Text dataText;
    private Quaternion quaternionStart;

    private void Start()
    {
        quaternionStart = this.transform.rotation;
    }

    // Update is called once per frame
    void Update () {
        if (active)
        {   
            this.transform.Rotate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
            if (dataText != null)
            {
                dataText.text = this.transform.rotation.ToString();
            }
        }
    }

    public void ResetRotation()
    {
        this.transform.rotation = quaternionStart;
    }

    public void changeActive()
    {
        active = !active;
    }

    public void changeSpeedX(float speed)
    {
        this.speedX = speed;
    }

    public void changeSpeedY(float speed)
    {
        this.speedY = speed;
    }

    public void changeSpeedZ(float speed)
    {
        this.speedZ = speed;
    }
}
