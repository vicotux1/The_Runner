using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour{
    public GameObject opciones, mainMenu;


    public void Quit(){
        Application.Quit();
        Debug.Log("deteniedo juego");
    }

    public void UpdateScreen(){
        Screen.fullScreen = !Screen.fullScreen;
    }
    public void UpdateQuality(int Quality) {
        QualitySettings.SetQualityLevel(Quality);
    }
        public void Vsync(int Vsync){
	QualitySettings.vSyncCount = Vsync;
	}
    public void antiAliasing_Quality (int Level){
	QualitySettings.antiAliasing = Level;
	}

    public void _LoadScene(string scene) {
          SceneManager.LoadScene(scene);
    }

    public void Opciones() {
        opciones.SetActive(true);
        mainMenu.SetActive(false);        
    }
    public void MainMenu() {
        opciones.SetActive(false);
        mainMenu.SetActive(true);        
    }
}
