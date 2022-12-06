using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer_clock : MonoBehaviour{
    public Text clock;
    float timer=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer=(timer +1*Time.deltaTime*100);
        clock.text=timer.ToString();
    }
}
