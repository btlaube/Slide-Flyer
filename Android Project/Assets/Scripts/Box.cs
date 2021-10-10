using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public int health = 10;
    public int points = 1;
    int healthRan;

    //public BoxHealth healthCount;
    public Text text;

    //public GameObject deathEffect;
    
    void Awake() {
        healthRan = Random.Range(5, 20);
    }

    void Start() {
        //healthCount.SetHealth(health);
        //int healthRan = Random.Range(5, 20);
        //health = healthRan;
        text.text = healthRan.ToString();
    }

    public void TakeDamage(int damage) {
        healthRan -= damage;
        if (healthRan <= 0) {
            Die();
        }
        //healthCount.SetHealth(health);
        text.text = healthRan.ToString();
    }

    void Die() {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        UnityEngine.Object.Destroy(gameObject);
        FindObjectOfType<GameManager>().AddPoints(points);
    }

}
