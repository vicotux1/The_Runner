using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class PointGame : MonoBehaviour{

    public Text PointText, Ganaste_text;
    public string Ganaste= "Ganaste!!!", Perdiste="Perdiste";
    public int _points;
    public AudioClip ganaste_Audio,perdiste_Audio;
    
    AudioSource audioSource;

    private void Start() {
        Ganaste_text.text="";
        audioSource=GetComponent<AudioSource>();
    }

    public void SoundFX(AudioClip Audio) {
        audioSource.clip=Audio;
        audioSource.Play();
    }
    public void GameOver() {
        Ganaste_text.text=Perdiste;
        SoundFX(perdiste_Audio);
        Update_Colectables(_points);
        Time.timeScale = 0;
    }
    public void Score(int value) {
        _points=_points+ value;
        Update_Colectables(_points);
    }

    public void Update_Colectables(int value){
        PointText.text ="Score: "+ value.ToString();
        /*if(_colectables==_total_Items){
        Ganaste_text.text=Ganaste;
        SoundFX(ganaste_Audio);
        Time.timeScale = 0;
        }*/
    }
}
