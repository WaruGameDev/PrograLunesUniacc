using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamManager : MonoBehaviour
{
    public CinemachineVirtualCamera[] cams;
    public int camToGo;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            foreach(CinemachineVirtualCamera c in cams)
            {
                c.Priority = 0;
            }
            cams[camToGo].Priority = 99;
        }
    }


}
