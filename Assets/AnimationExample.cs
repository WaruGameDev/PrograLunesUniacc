using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationExample : MonoBehaviour
{
    public Animator cubeAnimation;    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            cubeAnimation.SetBool("Run", true);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cubeAnimation.SetBool("Run", false);
        }

    }
}
