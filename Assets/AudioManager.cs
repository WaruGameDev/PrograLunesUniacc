using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider musicSlider;
    public Slider sfxSlider;
    
    
    
    public void ChangeMusicVolume()
    {
        audioMixer.SetFloat("VolumenMusic", musicSlider.value);
        
    }
    public void ChangeSFXVolume()
    {
        audioMixer.SetFloat("VolumenSFX", sfxSlider.value);
    }
}
