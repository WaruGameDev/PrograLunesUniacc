using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            health -= 10;
            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
