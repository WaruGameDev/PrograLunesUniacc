using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeroManager : MonoBehaviour
{
    public HeroBase actualHero;
    public TextMeshProUGUI heroInfoText;
    public AnimationCurve curve;

    private void Start()
    {
        heroInfoText.text = "Nombre del Heroe: " + actualHero.nameHero + "\n" +
            "Su ataque es: " + actualHero.atk + "\n" +
            "Su defensa es: " + actualHero.def + "\n" +
            "Su velocidad es: " + actualHero.speed
            ;
    }
}
