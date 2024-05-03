using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleBehavior : MonoBehaviour
{   
    public float speed = 5f;
    private SpriteRenderer spriteRenderer;
    private Vector3 movement;

    // Define the bounds
    private float minX = -9.17f;
    private float maxX = 8.95f;
    public bool grounded = true;
    private Rigidbody2D rb2d;
    private float jumpPower = 7.5f;
    private BoxCollider2D boxCollider2D;
    [SerializeField] private LayerMask platformsLayerMask;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb2d = rb2d = GetComponent<Rigidbody2D> ();
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        // Input handling
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = 0;
        movement = movement.normalized; // Normalize the movement vector to ensure constant speed diagonally

        // Move the character
        Vector3 newPosition = transform.position + (movement * speed * Time.deltaTime);
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX); // Clamp the x position
        transform.position = newPosition;

        // Update character sprite based on movement direction
        if (movement.x > 0)
        {
            // Move right
            SetSpriteDirection("Right");
        }
        else if (movement.x < 0)
        {
            // Move left
            SetSpriteDirection("Left");
        } 
        
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded()) 
        {
            rb2d.velocity = Vector2.up * jumpPower;
        }

    }

    // Function to change the character sprite based on movement direction
    void SetSpriteDirection(string direction)
    {
        // Load and assign the appropriate sprite image for the given direction
        Sprite sprite = Resources.Load<Sprite>("Sprites/" + direction); // Assuming sprite images are stored in a "Sprites" folder
        spriteRenderer.sprite = sprite;
    }

    private bool IsGrounded() 
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, platformsLayerMask);
        return raycastHit2D.collider != null;
    }
}
