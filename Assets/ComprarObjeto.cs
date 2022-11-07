using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprarObjeto : MonoBehaviour
{
    public int precio = 300;
    public void Comprar()
    {
        if(EconomyManager.instance.dinero >= precio)
        {
            EconomyManager.instance.AddOrRemoveDinero(-precio);
        }
        else
        {
            // no puedo comprar
            print("Eres pobre");
        }
    }
   
}
