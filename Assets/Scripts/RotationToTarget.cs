using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationToTarget : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        Vector3 selfRotation = transform.localEulerAngles;
        selfRotation.y = target.localEulerAngles.y;
        transform.eulerAngles = selfRotation;
        
    }
}
