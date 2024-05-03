using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableObject : MonoBehaviour
{
    public float pushForce = 10f; // Force applied when pushing the object
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody component of the object
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        // Check if the object is colliding with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector2 pushDirection = (transform.position - collision.transform.position).normalized;
            rb.AddForce(pushDirection * pushForce, ForceMode2D.Force); // Apply force in the opposite direction of the player
        }
    }
}
