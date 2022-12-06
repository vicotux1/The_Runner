using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class PointGame : MonoBehaviour{

    public Text PointText, Ganaste_text;
    public GameObject _restart;
    public string Ganaste= "Ganaste!!!", Perdiste="Perdiste";
    public int _points;
    public AudioClip ganaste_Audio,perdiste_Audio;
    
    AudioSource audioSource;

    private void Awake() {
        Ganaste_text.text="";
        audioSource=GetComponent<AudioSource>();
        Update_Colectables(_points);
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
        _restart.SetActive(true);
    }
    public void Score(int value) {
        _points=_points+ value;
        Update_Colectables(_points);
    }

    public void Update_Colectables(int value){
        PointText.text ="Score: "+ value.ToString();
    }
}
