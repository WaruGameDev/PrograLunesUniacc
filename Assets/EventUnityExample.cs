using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventUnityExample : MonoBehaviour
{
    public UnityEvent onMouseObjectClick;

    private void OnMouseDown()
    {
        onMouseObjectClick?.Invoke();
    }

}
