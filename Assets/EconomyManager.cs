using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomyManager : MonoBehaviour
{
    public static EconomyManager instance;
    public int dinero;
    private void Awake()
    {
        instance = this;
    }
    public void AddOrRemoveDinero(int dineroADar)
    {
        dinero += dineroADar;
    }

}
