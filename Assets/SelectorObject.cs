using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorObject : MonoBehaviour
{
    public GameObject selectObject;


    public void SelectObject()
    {
        ObjectCreator.instance.objectToCreate = selectObject;
    }
}
