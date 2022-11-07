using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Hero", menuName = "WalterHeroSystem/RPG", order = 0)]
public class HeroBase : ScriptableObject
{
    public string nameHero;
    public float atk;
    public float def;
    public float speed;    
}
