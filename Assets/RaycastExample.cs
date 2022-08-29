using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    public Material mat;
    private void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * 10, Color.red);
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            hit.transform.GetComponent<Renderer>().material = mat;
            hit.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}
