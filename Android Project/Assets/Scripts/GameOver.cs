using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string newGameScene;
    public string mainMenuScene;
    private int points;

    public void SetUp() {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        points = GameManager.score;
    }

    public void ReplayButton() {
        SceneManager.LoadScene(newGameScene);
        Time.timeScale = 1f;
    }

    public void MainMenuButton() {
        SceneManager.LoadScene(mainMenuScene);
        Time.timeScale = 1f;
    }

}
