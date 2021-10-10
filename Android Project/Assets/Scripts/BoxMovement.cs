using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{

    public static float speed = -1f;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.up * speed;
    }

    public void SetSpeed(float f) {
        speed = f;
    }

}
