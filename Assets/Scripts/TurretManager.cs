using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretManager : MonoBehaviour
{
    public GameObject turret;

    public List<GameObject> turretsInLevel;

    public LayerMask layer;
    public Vector3 offset = new Vector3(0, 0.5f, 0);

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, Mathf.Infinity, layer))
            {
                if(!hit.transform.CompareTag("Turret"))
                {
                    Instantiate(turret, hit.point + offset, Quaternion.identity);
                }
                
            }
        }
    }
}
