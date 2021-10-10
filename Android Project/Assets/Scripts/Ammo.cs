using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public int health = 10;
    public int ammoAmount = 20;

    //public GameObject deathEffect;
    
    public void TakeDamage(int damage) {
        health -= damage;
        if (health <= 0) {
            Die();
            //Fire.numBullets += ammoAmount;
            AddAmmo(ammoAmount);
        }
    }

    void AddAmmo(int n) {
        int newAmmo = FindObjectOfType<Fire>().GetNumBullets() + n;
        FindObjectOfType<Fire>().SetNumBullets(newAmmo);
    }

    void Die() {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        UnityEngine.Object.Destroy(gameObject);
    }

    public void SetAmmoAmount(int n) {
        ammoAmount = n;
    }

}
