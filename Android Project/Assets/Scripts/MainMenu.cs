using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string newGameScene;
    public string developerScene;

    public void NewGame() {
        //GameOver.gameOver = false; 
        //AmmoCount.ammoCount = 100;
        SceneManager.LoadScene(newGameScene);
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void Developer() {
        SceneManager.LoadScene(developerScene);
    }

}
