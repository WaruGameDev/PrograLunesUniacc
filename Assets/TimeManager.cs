using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float timeGame = 20;
    public AudioSource music;

    private void Update()
    {
        if(timeGame > 0)
        {
            timeGame -= 1 * Time.deltaTime;
        }
        if(timeGame < 10)
        {
            music.pitch = 2;
        }
    }
}
