using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    public bool active;
    public float speedX;
    public float speedY;
    public float speedZ;

    // Update is called once per frame
    void Update () {
        if (active)
        {   
            this.transform.Rotate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
        }
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
