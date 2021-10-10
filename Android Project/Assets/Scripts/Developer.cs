using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Developer : MonoBehaviour
{
    public string mainMenuScene;
    private TouchScreenKeyboard keyboard;
    private string input;

    public void MainMenu() {
        SceneManager.LoadScene(mainMenuScene);
    }

    public void OpenKeyboard() {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.ASCIICapable);
    }

    public void UpdateAmmo(string s) {
        input = s;
        int newAmmo = int.Parse(input);
        FindObjectOfType<Fire>().SetNumBullets(newAmmo);
        Debug.Log(newAmmo);
    }

    public void UpdateFireRate(string str) {
        float newFireRate = float.Parse(str);
        Debug.Log(newFireRate);
        FindObjectOfType<Fire>().SetFireRate(newFireRate);
        Debug.Log(newFireRate);
    }

    public void UpdateBlockSpeed(string s) {
        int newBlockSpeed = int.Parse(s);
        FindObjectOfType<BoxMovement>().SetSpeed(newBlockSpeed);
        Debug.Log(newBlockSpeed);
    }

    public void UpdateSpawnRate(string s) {
        float newSpawnRate = float.Parse(s);
        FindObjectOfType<Spawn>().SetSpawnRate(newSpawnRate);
        Debug.Log(newSpawnRate);
    }

    public void UpdateAmmoAmount(string s) {
        int newAmmoAmount = int.Parse(s);
        FindObjectOfType<Ammo>().SetAmmoAmount(newAmmoAmount);
        Debug.Log(newAmmoAmount);
    }

    public void UpdateTimeToSpawn(string s) {
        float newTimeToSpawn = float.Parse(s);
        FindObjectOfType<Spawn>().SetTimeToSpawn(newTimeToSpawn);
        Debug.Log(newTimeToSpawn);
    }

    public void ReadStringInput(string s) {
        input = s;
        Debug.Log(input);
    }

    public void ResetToDefault() {
        FindObjectOfType<Fire>().SetNumBullets(200);
        FindObjectOfType<Fire>().SetFireRate(0.1f);
        FindObjectOfType<BoxMovement>().SetSpeed(-1f);
        FindObjectOfType<Spawn>().SetSpawnRate(3.7f);
        FindObjectOfType<Ammo>().SetAmmoAmount(20);
        FindObjectOfType<Spawn>().SetTimeToSpawn(2f);
    }

}
