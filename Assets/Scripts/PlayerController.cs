using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedPlayer;
    [SerializeField] private Transform worldReference;
    [SerializeField] private Animator anim;
    bool attacking;
    public float timeToAttack = 0.8f;
    // Update is called once per frame
    void Update()
    {
        if(!attacking)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            transform.Translate(speedPlayer * x * worldReference.right * Time.deltaTime);
            transform.Translate(speedPlayer * z * worldReference.forward * Time.deltaTime);

            anim.SetFloat("groundSpeed", Mathf.Abs(x) + Mathf.Abs(z));
            if(Input.GetKeyDown(KeyCode.E))
            {
                Attack();
            }
        }
    }
    public void Attack()
    {
        attacking = true;
        anim.SetBool("Attack", attacking);
        StartCoroutine(Attacking());
    }
    public IEnumerator Attacking()
    {
        yield return new WaitForSeconds(timeToAttack);
        attacking = false;
        anim.SetBool("Attack", attacking);

        yield break;
    }
}
