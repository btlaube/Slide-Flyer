using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public GameObject countdown;

    void Start() {
        StartCoroutine("StartDelay");
    }

    IEnumerator StartDelay() {
        Time.timeScale = 0f;
        float pauseTime = Time.realtimeSinceStartup + 3f;
        while (Time.realtimeSinceStartup < pauseTime) {
            yield return 0;
        }
        countdown.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
