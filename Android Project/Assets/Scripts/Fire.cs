using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public int defaultBullets = 200;
    public static int numBullets = 20;
    public Transform firePoint;
    public GameObject bullet;
    public float fireRate = 0.5f;
    public float nextFire = 0f;

    void Start() {
        //numBullets = numBulletsEnter;
        SetNumBullets(defaultBullets);
    }

    public int GetNumBullets() {
        return numBullets;
    }

    public void SetNumBullets(int n) {
        numBullets = n;
    }

    public void SetFireRate(float f) {
        fireRate = f;
    }

    // Update is called once per frame
    void Update()
    {
        if (numBullets > 0 && Time.time > nextFire) {
            Shoot();
            nextFire = Time.time + fireRate;            
        }
        else if (numBullets <= 0) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void Shoot() {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        numBullets--;
    }

}
