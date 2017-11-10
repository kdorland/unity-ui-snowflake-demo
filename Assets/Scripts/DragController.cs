using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour
{
    public GameObject target;

    public void MoveCamera(BaseEventData data)
    {
        PointerEventData d = data as PointerEventData;
        target.transform.Rotate(new Vector3(0.0f, d.delta.x * -0.1f, 0.0f));
        target.transform.Translate(new Vector3(0.0f, 0.0f, d.delta.y * 0.01f));
    }

    public void MoveObject(BaseEventData data)
    {
        PointerEventData d = data as PointerEventData;
        target.transform.Translate(new Vector3(d.delta.x * 0.01f, d.delta.y * 0.01f, 0.0f), Space.World);
    }
}
