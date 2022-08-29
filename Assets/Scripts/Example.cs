using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Example : MonoBehaviour
{
    public Camera cam;
    public Color newColor;

    private void Start()
    {
        cam.clearFlags = CameraClearFlags.Color;
        cam.backgroundColor = newColor;
    }
}
