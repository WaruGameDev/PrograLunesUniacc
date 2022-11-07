using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Question", 
    menuName = "QuestionSystem/Question", order = 0)]
public class QuestionBase : ScriptableObject
{
    public string pregunta;
    public string[] respuestas;
    public int respuestaCorrectaIndex;
}
