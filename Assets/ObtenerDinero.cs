using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerDinero : MonoBehaviour
{
    public int dineroAAgregar = 10;
    public void AgregarDinero()
    {
        EconomyManager.instance.AddOrRemoveDinero(dineroAAgregar);
    }
}
