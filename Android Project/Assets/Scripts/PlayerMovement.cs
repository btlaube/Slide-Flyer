using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public int damage = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 ) {

            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touchPosition.y < -2.5) {

                touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0f;
                touchPosition.y = -2.5f;
                transform.position = touchPosition;
            }            
        }        
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        Box box = hitInfo.GetComponent<Box>();
        Ammo ammo = hitInfo.GetComponent<Ammo>();
        if (box != null) {
            FindObjectOfType<GameManager>().EndGame();
            UnityEngine.Object.Destroy(gameObject);
        }
        else if (ammo != null) {
            ammo.TakeDamage(damage);
        }
    }

}
