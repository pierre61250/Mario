using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ShowTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Timer : " + TimerText.Instance.timer);
        float maValeur = TimerText.Instance.timer;
        timerText.text = "Votre temps : " + maValeur.ToString("F2") + " secondes";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
