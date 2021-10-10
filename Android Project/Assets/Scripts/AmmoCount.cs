using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCount : MonoBehaviour
{
    public int ammoCount = Fire.numBullets;
    Text ammo;

    // Start is called before the first frame update
    void Start()
    {
        ammo = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ammoCount = Fire.numBullets;
        ammo.text = "Ammo: " + ammoCount;   
    }
}
