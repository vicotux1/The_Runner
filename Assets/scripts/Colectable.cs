using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectable : MonoBehaviour{
    public PointGame pointGame;
    public AudioClip _audio;
    public int value;
    public bool _IsObstaculo;
    public GameObject _Colectable;
    
    private void OnTriggerEnter(Collider other) {
        if(other.tag=="Player"&& _IsObstaculo==false){
            _Colectable.SetActive(false);
            pointGame.Score(value);
            pointGame.SoundFX(_audio);
        }if(other.tag=="Player"&& _IsObstaculo==true){
            pointGame.GameOver();
        }
    }
}
