using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterPlayMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public bool isPlaying;
    private void OnTriggerEnter(Collider other)
    {
        if(!isPlaying)
        {
            audioSource.Play();
            isPlaying = true;
        }
        else if(isPlaying)
        {
            audioSource.Stop();
            isPlaying = false;
        }
        
    }
}
