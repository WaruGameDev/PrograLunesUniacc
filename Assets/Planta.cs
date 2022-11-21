using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Planta : MonoBehaviour
{
    bool suscrito = true;
    private void Start()
    {
        RegadorManager.instance.alRegar += Regar;
        suscrito = true;
    }
    public void Regar(float time)
    {
        transform.DOShakeScale(time);
    }
    private void OnMouseDown()
    {
        if(suscrito)
        {
            RegadorManager.instance.alRegar -= Regar;
            suscrito = false;
        }
        else if (!suscrito)
        {
            RegadorManager.instance.alRegar += Regar;
            suscrito = true;
        }
       
    }
}
