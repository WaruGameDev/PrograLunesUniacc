using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterEvemt : MonoBehaviour
{
    public UnityEvent onTriggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            onTriggerEnterEvent?.Invoke();
        }
    }
}
