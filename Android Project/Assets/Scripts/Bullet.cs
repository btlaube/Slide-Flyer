using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 1;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        Box box = hitInfo.GetComponent<Box>();
        Ammo ammo = hitInfo.GetComponent<Ammo>();
        if (box != null) {
            box.TakeDamage(damage);
        }
        else if (ammo != null) {
            ammo.TakeDamage(damage);
        }
        UnityEngine.Object.Destroy(gameObject);
    }

}
