using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public static int score;
    public static int numBullets;

    public GameOver gameOverScreen;
    bool gameOver = false;
    public float restartDelay = 1f;

    public void EndGame() {
        if (gameOver == false) {
            gameOver = true;
            Debug.Log("Game over");
            Invoke("LoadGameOver", restartDelay);
        }        
    }

    void LoadGameOver() {
        gameOverScreen.SetUp();
    }

    public void AddPoints(int n) {
        score += n;
    }

}
