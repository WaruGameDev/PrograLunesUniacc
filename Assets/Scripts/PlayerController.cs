using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedPlayer;
    [SerializeField] private Transform worldReference;
    [SerializeField] private Animator anim;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(speedPlayer * x * worldReference.right * Time.deltaTime);
        transform.Translate(speedPlayer * z * worldReference.forward * Time.deltaTime);

        anim.SetFloat("xSpeed", Mathf.Abs(x + z));
    }
}
