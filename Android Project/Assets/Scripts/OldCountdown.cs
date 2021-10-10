using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OldCountdown : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 3f;

    public Text countdown;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        //Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime >= 0) {
            currentTime -= 1 * Time.deltaTime;
            countdown.text = currentTime.ToString("0");
        }
        else {
            gameObject.SetActive(false);
            //Time.timeScale = 1f;
        }
    }
}
