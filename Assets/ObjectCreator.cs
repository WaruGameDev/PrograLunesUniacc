using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public static ObjectCreator instance;
    public GameObject objectToCreate;
    public LayerMask layer;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layer))
            {
                if (!hit.transform.CompareTag("Turret"))
                {
                    Instantiate(objectToCreate, hit.point, Quaternion.identity);
                }

            }
        }
    }
}
