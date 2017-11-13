using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour
{
    public GameObject target;
    public float moveDelta = 0.1f;

    public void MoveCamera(BaseEventData data)
    {
        PointerEventData d = data as PointerEventData;
        target.transform.Rotate(new Vector3(0.0f, d.delta.x * -moveDelta, 0.0f));
        target.transform.Translate(new Vector3(0.0f, 0.0f, d.delta.y * moveDelta));
    }

    public void MoveObject(BaseEventData data)
    {
        PointerEventData d = data as PointerEventData;
        target.transform.Translate(new Vector3(d.delta.x * moveDelta, d.delta.y * moveDelta, 0.0f), Space.World);
    }
}
