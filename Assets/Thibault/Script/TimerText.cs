using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    public float timer = 0f;
    public TextMeshProUGUI timerText; // Assure-toi de faire référence à ton objet Text UI dans l'éditeur Unity
    public static TimerText Instance;

    void Update()
    {
        if(timerText != null) {
            timer += Time.deltaTime; // Incrémente le timer avec le temps écoulé depuis la dernière frame
            timerText.text = timer.ToString("F2"); // Affiche le temps restant en arrondissant à 2 décimales
            Instance = this;
            TimerText.Instance.timer = timer;
        }


    }
}
