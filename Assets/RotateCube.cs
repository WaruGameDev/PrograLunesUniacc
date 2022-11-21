using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public bool rotate;
    // Update is called once per frame
    void Update()
    {
        if(rotate)
        {
            transform.Rotate(Vector3.up * 50);
        }
    }
    public void SetRotate(bool rot)
    {
        rotate = rot;
    }
}
