using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform target;
    public Transform turret;

    [Header("Canon")]
    public GameObject bullet;
    public Transform canon;
    public float fireRate = 1;
    private float timeToFireRate = 0;
    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            turret.LookAt(target);
            if (timeToFireRate < fireRate)
            {
                timeToFireRate += 1 * Time.deltaTime;
                if (timeToFireRate >= fireRate)
                {
                    Shoot();
                    timeToFireRate = 0;
                }
            }
        }
        
    }
    public void Shoot()
    {
        GameObject bulletGO = Instantiate(bullet, canon.position, Quaternion.identity);
        bulletGO.GetComponent<Rigidbody>().AddForce(canon.forward * 1500);
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Unit"))
        {
            target = null;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Unit") && target == null)
        {
            target = other.transform;
        }
    }
}
