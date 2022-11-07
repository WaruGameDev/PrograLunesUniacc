using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public static QuestionManager instance;
    public GameObject panelPregunta, panelGanador;
    public TextMeshProUGUI preguntaText;
    public List<TextMeshProUGUI> respuestasText;
    public List<QuestionBase> actualQuestion;

    public int puntajeActual;
    public int puntajePorPregunta = 10;
    public TextMeshProUGUI puntajeText;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        SetQuestion();
    }
    public void SetQuestion()
    {
        if(actualQuestion.Count>0)
        {
            preguntaText.text = actualQuestion[0].pregunta;
            for (int i = 0; i < respuestasText.Count; i++)
            {
                respuestasText[i].text = actualQuestion[0].respuestas[i];
            }
        }
        else
        {
            panelPregunta.SetActive(false);
            panelGanador.SetActive(true);
            puntajeText.text = "Tu puntaje total es: " + puntajeActual;
        }
        
    }
    public void Response(int response)
    {
        if(response == actualQuestion[0].respuestaCorrectaIndex)
        {
            puntajeActual += puntajePorPregunta;
            print("Respuesta correcta");
        }
        else
        {
            puntajeActual -= (int)puntajePorPregunta / 2;
            if(puntajeActual <= 0)
            {
                puntajeActual = 0;
            }
            print("Respuesta incorrecta");
        }
        actualQuestion.RemoveAt(0);
        SetQuestion();
    }
   
}
